using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TimeMachine.FileLog
{
    public static class FileLogger
    {
        private static string url;

        public static string Url { get => url; set => url = value; }

        public static void WriteLine(string value)
        {
            if(!File.Exists(Url))
            {
                // Console.WriteLine("It seems like the url to the file is incorrect");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(Url, true, Encoding.Default))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy" + "-" + "mm" +"-" + "dd" + "-" + "HH:MM:SS") + ": " + value);
                }
                // Console.WriteLine("string add to log");
            }
        }
    }
}
