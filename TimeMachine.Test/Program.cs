using System;

namespace TimeMachine.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeMachine.FileLog.FileLogger.Url = @"D:\test\log.txt";
            TimeMachine.FileLog.FileLogger.WriteLine("This is a string");
        }
    }
}
