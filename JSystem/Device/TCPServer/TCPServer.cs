using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using Newtonsoft.Json;
using JLogging;

namespace JSystem.Device
{
    public class TCPServer : DeviceBase
    {
        protected int _maxLength = 4096;

        [JsonIgnore]
        public List<byte> Buffer { get; private set; } = new List<byte>();

        private Socket _socketWatch = null;

        private bool _isListening = false;

        [JsonIgnore]
        public Action<byte[]> OnDispMsg;

        [JsonIgnore]
        public Action OnSendConnResult;

        private byte[] _buffer;

        protected Socket _socket = null;

        public int Port = 8088;

        public TCPServer() { }

        public TCPServer(string nameZh) : this()
        {
            Name = nameZh;
        }

        public override void InitView()
        {
            _view = new TCPServerView(this);
        }

        public override bool Connect()
        {
            try
            {
                _buffer = new byte[_maxLength];
                _socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, Port);
                _socketWatch.Bind(ipPoint);
                _socketWatch.Listen(10);
                _isListening = true;
                _socketWatch.BeginAccept(new AsyncCallback(ClientAccepted), _socketWatch);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void DisConnect()
        {
            _isListening = false;
            _socket?.Close();
            _socketWatch?.Close();
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isListening);
            return _isListening;
        }

        public bool CheckClientConnection()
        {
            return !(_socket == null || !_socket.Connected || (_socket.Poll(1000, SelectMode.SelectRead) && _socket.Available == 0));
        }

        /// <summary>
        /// 接收某一个客户端的消息
        /// </summary>
        /// <param name="ar"></param>
        private void ReceiveMessage(IAsyncResult ar)
        {
            if (_isListening == false)
                return;
            try
            {
                var socket = ar.AsyncState as Socket;
                if (!CheckClientConnection())
                    return;
                int length = socket.EndReceive(ar);
                byte[] data = new byte[length];
                System.Buffer.BlockCopy(_buffer, 0, data, 0, length);
                OnDispMsg?.Invoke(data);
                Buffer.AddRange(data);
                //接收下一个消息(因为这是一个递归的调用，所以这样就可以一直接收消息）异步
                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
            }
            catch (Exception ex)
            {
                LoggingIF.Log(ex.Message);
            }
        }

        public bool WriteCommand(byte[] data)
        {
            if (!CheckClientConnection())
                return false;
            _socket?.Send(data);
            return true;
        }

        public void ClearBuffer()
        {
            Buffer.Clear();
        }

        private void ClientAccepted(IAsyncResult ar)
        {
            if (_isListening == false)
                return;
            var socket = ar.AsyncState as Socket;
            _socket = socket?.EndAccept(ar);
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), _socket);
            OnSendConnResult?.Invoke();
            //准备接受下一个客户端请求(异步)
            socket.BeginAccept(new AsyncCallback(ClientAccepted), socket);
        }
    }
}
