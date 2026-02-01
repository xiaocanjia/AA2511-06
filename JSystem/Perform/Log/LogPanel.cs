using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FileHelper;

namespace JSystem.Perform
{
    public partial class LogPanel : UserControl
    {
        public LogPanel()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.ShowAlways = true;
            tip.SetToolTip(Btn_Open_Dir, "打开日志路径");
            LogManager.Instance.OnAddLog = ShowLog;
            DatePicker_Error.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DatePicker_Error_TextChanged(null, null);
        }

        public void ShowLog(string msg, bool isError)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { ShowLog(msg, isError); }));
            }
            else
            {
                TB_Running_Log.AppendText(msg);
            }
        }

        private void Btn_Open_Dir_Click(object sender, EventArgs e)
        {
            string logDir = IniHelper.INIGetStringValue(AppDomain.CurrentDomain.BaseDirectory + "LogConfig.ini", "Options", "LogDir", @"C:\");
            if (!Directory.Exists(logDir))
                logDir = AppDomain.CurrentDomain.BaseDirectory;
            System.Diagnostics.Process.Start(logDir + "JLog");
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "配置文件|*.log";
                if (dialog.ShowDialog() != DialogResult.OK) return;
                TxtHelper.FileWrite(dialog.FileName, TB_Running_Log.Text);
            }
        }

        private void Tab_Log_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab_Log.SelectedIndex == 0)
                DatePicker_Error.Visible = false;
            else
            {
                DatePicker_Error.Visible = true;
                DatePicker_Error_TextChanged(null, null);
            }
        }

        private void DatePicker_Error_TextChanged(object sender, EventArgs e)
        {
            TB_Error_Log.Clear();
            string logDir = IniHelper.INIGetStringValue(AppDomain.CurrentDomain.BaseDirectory + "LogConfig.ini", "Options", "LogDir", @"C:\");
            if (!Directory.Exists(logDir))
                logDir = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = $"{logDir}JLog\\{DatePicker_Error.Text}\\Error.log";
            //当前日期的被占用，无法读取
            if (!File.Exists(filePath))
                return;
            StreamReader sr = new StreamReader(filePath);
            string allStr = sr.ReadToEnd();
            string[] arrayStr1 = Regex.Split(allStr, "\r\n");
            foreach (string str in arrayStr1)
            {
                string[] arrayStr2 = str.Split('\t');
                if (arrayStr2[0] == "") continue;
                TB_Error_Log.AppendText(arrayStr2[0] + " " + arrayStr2[arrayStr2.Length - 1] + "\r\n");
            }
            sr.Close();
        }
    }
}
