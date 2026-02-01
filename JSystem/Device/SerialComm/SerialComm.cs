using System;
using System.IO.Ports;
using System.Collections.Generic;
using Newtonsoft.Json;
using JLogging;

namespace JSystem.Device
{
    public class SerialComm : DeviceBase
    {
        private SerialPort _port;

        public string PortName = "COM1";

        public int BaudRate = 115200;

        public int DataBits = 8;

        public StopBits StopBits = StopBits.One;

        public Parity Parity = Parity.None;

        protected List<byte> _bufferList = new List<byte>();

        protected int _maxBytes = 32768;

        private bool _isConnected = false;

        [JsonIgnore]
        public Action<string, byte[]> OnDispMsg;

        public SerialComm()
        {
        }

        public SerialComm(string name)
        {
            Name = name;
        }

        public override void InitView()
        {
            _view = new SerialCommView(this);
        }

        public override bool Connect()
        {
            try
            {
                if (!IsEnable) return true;
                _port = new SerialPort
                {
                    PortName = PortName,
                    BaudRate = BaudRate,
                    DataBits = DataBits,
                    StopBits = StopBits,
                    Parity = Parity
                };
                _port.DataReceived += PortDataReceived;
                _port.RtsEnable = true;
                _port.DtrEnable = true;
                _port.Open();
                _isConnected = true;
                return true;
            }
            catch
            {
                _isConnected = false;
                return false;
            }
        }

        public virtual void WriteData(string cmd)
        {
            if (!CheckConnection())
                return;
            _port?.Write(cmd);
        }

        public virtual void WriteData(byte[] cmd)
        {
            if (!CheckConnection())
                return;
            _port?.Write(cmd, 0, cmd.Length);
            OnDispMsg?.Invoke("发", cmd);
        }

        public List<byte> ReadData()
        {
            return _bufferList;
        }

        public void ClearBuffer()
        {
            if (!CheckConnection())
                return;
            _bufferList.Clear();
            _port?.DiscardInBuffer();
        }

        public override void DisConnect()
        {
            _port?.Close();
            _port?.Dispose();
            _isConnected = false;
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isConnected);
            return _isConnected;
        }

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (_port.BytesToRead == 0)
                    return;
                if (_bufferList.Count > _maxBytes)
                    _bufferList.Clear();
                byte[] dataBytes = new byte[_port.BytesToRead];
                _port.Read(dataBytes, 0, dataBytes.Length);
                _bufferList.AddRange(dataBytes);
                OnDispMsg?.Invoke("收", dataBytes);
            }
            catch (Exception ex)
            {
                LoggingIF.Log(ex.Message, LogLevels.Error);
            }
        }
    }
}
