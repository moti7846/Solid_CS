using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Email : IEmailAlert
    {
        //string To;
        //public Email(string to)
        //{
        //    To = to;
        //}

        public void Send(string To, string message)
        {
            Console.WriteLine($"to: {To}, message:{message}");
        }
    }
}
