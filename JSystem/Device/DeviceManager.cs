using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using FileHelper;
using JSystem.Perform;

namespace JSystem.Device
{
    public class DeviceManager
    {
        private List<DeviceBase> _deviceList;

        public List<DeviceBase> DeviceList
        {
            get { return _deviceList; }
            set
            {
                for (int i = 0; i < _deviceList.Count; i++)
                {
                    _deviceList[i].DisConnect();
                    _deviceList[i] = value.FindLast((d) => d.Name == _deviceList[i].Name && d.GetType() == _deviceList[i].GetType()) ?? _deviceList[i];
                }
            }
        }
        
        public Action<string> OnSetUserRight;

        public Action<string, bool> OnSetOut;
        
        private bool _isMonitor = false;

        public DeviceManager()
        {
            _deviceList = new List<DeviceBase>();
            _deviceList.Add(new MesSys("Mes系统"));
            _deviceList.Add(new Board("轴卡1"));
            _deviceList.Add(new Board("轴卡2"));
            _deviceList.Add(new Board("轴卡3"));
            _deviceList.Add(new Board("IO卡"));
            _deviceList.Add(new SerialScanningGun("A轨扫码枪"));
            _deviceList.Add(new SerialScanningGun("B轨扫码枪"));
            _deviceList.Add(new Camera2D("上料相机"));
            _deviceList.Add(new Camera2D("左工位相机"));
            _deviceList.Add(new Camera2D("右工位相机"));
            _deviceList.Add(new LightController("上料光源"));
            _deviceList.Add(new LightController("左工位光源"));
            _deviceList.Add(new LightController("右工位光源"));
            _deviceList.Add(new HeightSensor("生料测高仪1"));
            _deviceList.Add(new HeightSensor("生料测高仪2"));
            _deviceList.Add(new HeightSensor("熟料测高仪1"));
            _deviceList.Add(new HeightSensor("熟料测高仪2"));
            _deviceList.Add(new RollPressSensor("左滚压压力传感器"));
            _deviceList.Add(new RollPressSensor("右滚压压力传感器"));
            _deviceList.Add(new DirectPressSensor("左直压压力传感器"));
            _deviceList.Add(new DirectPressSensor("右直压压力传感器"));
            _deviceList.Add(new Barometer("左气压比例阀"));
            _deviceList.Add(new Barometer("右气压比例阀"));
            List<DeviceBase> deviceList = JsonHelper.Deserilize<List<DeviceBase>>(AppDomain.CurrentDomain.BaseDirectory + "Project\\Devices.json");
            if (deviceList != null)
            {
                for (int i = 0; i < _deviceList.Count; i++)
                {
                    DeviceBase dev = deviceList.Find((d) => d.Name == _deviceList[i].Name);
                    if (dev != null)
                        _deviceList[i] = dev;
                }
            }
        }

        public DeviceBase GetDevice(string name)
        {
            return _deviceList.Find((device) => device.Name == name);
        }

        public List<DeviceBase> GetBoards()
        {
            return _deviceList.FindAll((device) => (device as Board) != null);
        }

        public bool Init()
        {
            bool ret = true;
            foreach (DeviceBase device in _deviceList)
            {
                if (!device.IsEnable || device.CheckConnection())
                    continue;
                if (!device.Connect())
                {
                    LogManager.Instance.AddLog("设备", $"{device.Name}连接失败", JLogging.LogLevels.Error);
                    ret &= false;
                    continue;
                }
            }
            _isMonitor = true;
            new Task(DevicesMonitor).Start();
            return ret;
        }

        public void UnInit()
        {
            _isMonitor = false;
            foreach (DeviceBase device in _deviceList)
                device.DisConnect();
        }

        private void DevicesMonitor()
        {
            while (_isMonitor)
            {
                Thread.Sleep(500);
                for (int i = 0; i < DeviceList.Count; i++)
                {
                    if (!_isMonitor) return;
                    DeviceList[i].CheckConnection();
                }
            }
        }
    }
}
