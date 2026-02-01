using System;
using JSystem.Perform;
using JSystem.Station;
using JSystem.Device;
using JSystem.IO;
using JSystem.Param;
using JSystem.Project;
using FileHelper;
using JLogging;

namespace JSystem
{
    public class SysController
    {
        public EDeviceState CurrState = EDeviceState.UNINIT;

        public SysManagers SysMgrs;

        public ProjectManager ProjectMgr;

        public StationManager StationMgr;

        public DeviceManager DeviceMgr;

        public IOManager IOMgr;

        public ParamManager ParamMgr;

        public Action OnUpdateUI;

        public Action<bool> OnSetEnable;

        public Action<EDeviceState> OnUpdateState;

        public SysController()
        {
            try
            {
                IOMgr = new IOManager();
                SysMgrs = new SysManagers();
                ParamMgr = new ParamManager();
                ProjectMgr = new ProjectManager();
                StationMgr = new StationManager();
                DeviceMgr = new DeviceManager();
                RegisterEvents();
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", ex.Message, LogLevels.Error);
            }
        }

        public bool Init()
        {
            if (CurrState == EDeviceState.INITING)
                return false;
            if (!IOMgr.ResetSafeCheck() || !IOMgr.CheckIsSafe())
                return false;
            OnUpdateState(EDeviceState.INITING);
            LogManager.Instance.AddLog("主流程", "开始初始化");
            if (!DeviceMgr.Init())
            {
                OnUpdateState(EDeviceState.EMERGENCY);
                LogManager.Instance.AddLog("主流程", "初始化失败");
                return false;
            }
            if (!IOMgr.Init())
            {
                OnUpdateState(EDeviceState.EMERGENCY);
                LogManager.Instance.AddLog("主流程", "IO表配置异常，初始化失败");
                return false;
            }
            if (!StationMgr.Reset())
            {
                OnUpdateState(EDeviceState.EMERGENCY);
                LogManager.Instance.AddLog("主流程", "初始化失败");
                return false;
            }
            OnUpdateState(EDeviceState.INITED);
            LogManager.Instance.AddLog("主流程", "初始化完成");
            return true;
        }

        public bool Start()
        {
            if (CurrState == EDeviceState.RUN)
                return true;
            if (CurrState == EDeviceState.UNINIT)
            {
                LogManager.Instance.AddLog("主流程", "设备未初始化");
                return false;
            }
            if (!StationMgr.Start())
            {
                LogManager.Instance.AddLog("主流程", "启动失败，请重新初始化");
                return false;
            }
            IOMgr.Start();
            LogManager.Instance.AddLog("主流程", "设备已启动");
            OnSetEnable?.Invoke(false);
            OnUpdateState(EDeviceState.RUN);
            return true;
        }

        public bool Pause(bool isNormal)
        {
            if (CurrState != EDeviceState.RUN)
                return true;
            if (!StationMgr.Pause())
                return false;
            LogManager.Instance.AddLog("主流程", $"设备已暂停");
            if (isNormal)
                OnUpdateState(EDeviceState.PAUSE);
            else
                OnUpdateState(EDeviceState.PAUSEALARM);
            return true;
        }

        public bool Stop(bool isNormal)
        {
            if (CurrState == EDeviceState.UNINIT)
                return true;
            if (StationMgr == null || !StationMgr.End())
                return false;
            IOMgr.Stop();
            OnSetEnable?.Invoke(true);
            if (isNormal)
                OnUpdateState(EDeviceState.UNINIT);
            else
                OnUpdateState(EDeviceState.EMERGENCY);
            return true;
        }

        public void UnInit()
        {
            LogManager.Instance.AddLog("主流程", $"软件已关闭", LogLevels.Debug);
            Stop(true);
            StationMgr?.UnInit();
            IOMgr?.UnInit();
            DeviceMgr?.UnInit();
        }

        private bool SaveProject(string filePath)
        {
            try
            {
                SysMgrs.PointsList = StationMgr.PointsList;
                SysMgrs.Meas2DMgrA = ((TransferStation)StationMgr.GetStation("搬运工站")).Meas2DMgrA;
                SysMgrs.Meas2DMgrB = ((TransferStation)StationMgr.GetStation("搬运工站")).Meas2DMgrB;
                SysMgrs.Meas2DMgrL = ((TestStation)StationMgr.GetStation("左测试工站")).Meas2DMgr;
                SysMgrs.Meas2DMgrR = ((TestStation)StationMgr.GetStation("右测试工站")).Meas2DMgr;
                JsonHelper.Serilize(SysMgrs, filePath);
                JsonHelper.Serilize(DeviceMgr.DeviceList, AppDomain.CurrentDomain.BaseDirectory + "Project\\Devices.json");
                IOMgr.Save();
                StationMgr.Save();
                ParamMgr.Save();
                return true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"项目文件保存失败，请检查Excel表格是否关闭：{ex.Message}", LogLevels.Error);
                return false;
            }
        }

        private bool LoadProject(string filePath)
        {
            try
            {
                SysMgrs = JsonHelper.Deserilize<SysManagers>(filePath);
                StationMgr.PointsList = SysMgrs.PointsList ?? StationMgr.PointsList;
                ((TransferStation)StationMgr.GetStation("搬运工站")).Meas2DMgrA = SysMgrs.Meas2DMgrA ?? ((TransferStation)StationMgr.GetStation("搬运工站")).Meas2DMgrA;
                ((TransferStation)StationMgr.GetStation("搬运工站")).Meas2DMgrB = SysMgrs.Meas2DMgrB ?? ((TransferStation)StationMgr.GetStation("搬运工站")).Meas2DMgrB;
                ((TestStation)StationMgr.GetStation("左测试工站")).Meas2DMgr = SysMgrs.Meas2DMgrL ?? ((TestStation)StationMgr.GetStation("左测试工站")).Meas2DMgr;
                ((TestStation)StationMgr.GetStation("右测试工站")).Meas2DMgr = SysMgrs.Meas2DMgrR ?? ((TestStation)StationMgr.GetStation("右测试工站")).Meas2DMgr;
                OnUpdateUI?.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"项目文件加载失败：{ex.Message}", LogLevels.Error);
                return false;
            }
        }

        public void RegisterEvents()
        {
            try
            {
                IOMgr.OnInit = Init;
                IOMgr.OnStart = Start;
                IOMgr.OnStop = Stop;
                IOMgr.OnPause = Pause;
                IOMgr.OnGetDevice = DeviceMgr.GetDevice;
                IOMgr.OnGetBoards = DeviceMgr.GetBoards;
                DeviceMgr.OnSetOut = IOMgr.SetOut;
                ProjectMgr.OnLoadProject = LoadProject;
                ProjectMgr.OnSaveProject = SaveProject;
                StationMgr.OnGetDevice = DeviceMgr.GetDevice;
                StationMgr.OnGetIn = IOMgr.GetIn;
                StationMgr.OnSetOut = IOMgr.SetOut;
                StationMgr.OnGetEdgeSignal = IOMgr.GetEdgeSignal;
                StationMgr.RegisterEvents();
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog("主流程", $"事件注册失败，构造函数初始化失败：{ex.Message}", LogLevels.Error);
            }
        }
    }
}
