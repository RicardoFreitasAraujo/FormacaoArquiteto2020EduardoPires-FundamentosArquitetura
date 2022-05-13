using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    //Ada ptee
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }
    }
}
