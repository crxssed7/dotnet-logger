using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dotnetlogger
{
    public class DotNetLogger
    {
        private List<string> logs = new List<string>();
        private LogWindow window = new LogWindow();

        public void Log(string logMessage, bool writeToConsole = true)
        {
            // Log example - [18:28]: logMessage
            string log = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}]: {logMessage}";
            logs.Add(log);
            window.AppendText(log);
            if (writeToConsole)
                Console.WriteLine(log);
        }

        public void ShowLogger()
        {
            window.Show();
        }

        public string GenerateLogFileName(string projectName)
        {
            // log example - 2021-03-02_appname.log
            return $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}_{projectName}.log";
        }

        public void SaveLogs(string logFile, bool append)
        {
            using (StreamWriter writer = new StreamWriter(logFile, append: append))
            {
                for (int i = 0; i < logs.Count; i++)
                {
                    writer.WriteLine(logs[i]);
                }
            }
        }

        public void ClearLogs(bool keepWindowLogs = true)
        {
            logs.Clear();
            if (!keepWindowLogs)
                window.RemoveText();
        }
    }
}
