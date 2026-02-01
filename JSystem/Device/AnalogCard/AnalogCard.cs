using Automation.BDaq;

namespace JSystem.Device
{
    public class AnalogCard : DeviceBase
    {
        private bool _isConnected = false;

        private InstantAiCtrl instantAiCtrl = null;

        public AnalogCard() { }

        public AnalogCard(string name) : this()
        {
            Name = name;
        }

        public void StopInstantAI()
        {
            instantAiCtrl.Dispose(); ;
        }

        public override void InitView()
        {
            _view = new AnalogCardView(this);
        }

        public override bool Connect()
        {
            try
            {
                if (!IsEnable)
                    return true;
                instantAiCtrl = new InstantAiCtrl();
                instantAiCtrl.SelectedDevice = new DeviceInformation(0x1);//0x1是设备编号  
                _isConnected = instantAiCtrl.Initialized;
                return _isConnected;
            }
            catch
            {
                _isConnected = false;
                return false;
            }
        }

        public override void DisConnect()
        {
            instantAiCtrl.Dispose();
            _isConnected = false;
        }

        public override bool CheckConnection()
        {
            OnUpdateStatus?.Invoke(_isConnected);
            return _isConnected;
        }

        public double ReadData(int channel)
        {
            ErrorCode er0 = instantAiCtrl.Read(channel, out double data);
            return data;
        }
    }

}