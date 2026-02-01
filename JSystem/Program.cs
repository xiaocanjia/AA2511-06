using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace JSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ThreadPool.SetMinThreads(1000, 1000);
            ThreadPool.SetMaxThreads(1000, 1000);
            string processName = Process.GetCurrentProcess().ProcessName;
            var processes = Process.GetProcessesByName(processName);
            if (processes.Length > 1)
            {
                MessageBox.Show("程序已打开，请勿重复打开！", "重复打开");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WaitForm waitForm = null;
            new Task(() =>
            {
                waitForm = new WaitForm();
                waitForm.ShowIcon = true;
                Application.Run(waitForm);
            }).Start();
            MainWindow win = new MainWindow();
            SysController controller = new SysController();
            controller.DeviceMgr.Init();
            controller.IOMgr.Init();
            win.Init(controller);
            controller.ProjectMgr?.LoadProject();
            waitForm.Invoke(new Action(() => { waitForm.Close(); }));
            Application.Run(win);
        }
    }
}
