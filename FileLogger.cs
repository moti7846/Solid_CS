using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solid_Principle
{
    internal class FileLogger : ILogger
    {
        public void log()
        {
            File.WriteAllText("log.txt", "EMERGENCY OCCURRED");
        }
        //public static void log(string msg)
        //{
        //    File.WriteAllText("log.txt", msg);
        //}

    }
}
