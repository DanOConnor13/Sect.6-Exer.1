using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sect._6_Exer._1
{
    class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email notification has been sent to video owner.");
        }

    }
}
