using System;
using System.IO;

namespace StoreAndSalesUI.Helpers
{
    public class Logger
    {
        public void Log(string logMessage, string logFilePath)
        {
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($" {DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt") } \n { logMessage } \n \t \t \t ********EndLOG*******");
            }
        }
    }
}
