using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        ILogger Logger;
        IEmailAlert Email;
        int Phone;
        public EmergencyHandler(ILogger logger,string email,int phone)
        {
            Logger = logger;
            //Email Email = new Email(email);
            Phone = phone;
        }

        public void EmergencyShutdown()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            Logger.log();
            //Email.Send(Emaill, "Emergency triggered");
        }
    }
}
