using System;
using JLogging;
using System.Runtime.CompilerServices;
using System.IO;
using FileHelper;
using System.Text;

namespace JSystem.Perform
{
    public class LogManager
    {
        private static LogManager _instance;

        public static LogManager Instance => _instance ?? (_instance = new LogManager());

        public Action<string, bool> OnAddLog;
        
        private readonly object _lock = new object();

        public void AddLog(string title, string msg, LogLevels level = LogLevels.Info, [CallerFilePath] string filePath = "",
            [CallerMemberName] string caller = "", [CallerLineNumber] int lineNum = 0)
        {
            lock(_lock)
            {
                LoggingIF.Log(title + "\t" + msg, level, filePath, caller, lineNum);
                if (level != LogLevels.Debug)
                    OnAddLog?.Invoke(DateTime.Now.ToString("HH:mm:ss:fff  ") + title + "\t" + msg + "\r\n", level == LogLevels.Error);
            }
        }

        public void AddPdtLog(string pdtLog, string msg)
        {
            if (pdtLog == "" || pdtLog == null) return;
            if (!Directory.Exists(pdtLog))
                Directory.CreateDirectory(pdtLog);
            using (StreamWriter stream = new StreamWriter($"{pdtLog}//Run.txt", true, Encoding.UTF8))
                stream.Write($"{DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss.fff")}\t{msg}\r\n");
        }
    }
}
