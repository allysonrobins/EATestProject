using System;
using System.IO;

namespace EAAutoFramework.Helpers
{
    public class LogHelpers
    {
        //Global Declaration
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;

        //Create a file which can store the log information
        public static void CreateLogFile()
        {
            string dir = @"e:\EAAutoFramework\";
            if (Directory.Exists(dir))
            {
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
        }
    }
}
