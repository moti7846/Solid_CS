using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Subscribe to DatabaseLogger: EMERGENCY OCCURRED");
        }
    }
}
