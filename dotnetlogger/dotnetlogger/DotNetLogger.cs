using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlogger
{
    public class DotNetLogger
    {
        private List<string> logs = new List<string>();
        private LogWindow window = new LogWindow();

        public void Log(string logMessage)
        {
            // Log example - [18:28]: logMessage
            string log = $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}]: {logMessage}";
            logs.Add(log);
            window.AppendText(log);
        }

        public void ShowLogger()
        {
            window.Show();
        }
    }
}
