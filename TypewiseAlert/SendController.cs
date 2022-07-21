using System;
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
