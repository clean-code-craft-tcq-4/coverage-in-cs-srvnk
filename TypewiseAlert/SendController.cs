using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TypewiseAlert.Enums;

namespace TypewiseAlert
{
    public class SendController
    {
        public static bool sendToController(BreachType breachType)
        {
            try
            {
                const ushort header = 0xfeed;
                Console.WriteLine("{} : {}\n", header, breachType);

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        } 
    }
}
