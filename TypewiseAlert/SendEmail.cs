using System;
using System.Collections.Generic;
using System.Linq;
using static TypewiseAlert.Enums;

namespace TypewiseAlert
{
    public class SendEmail
    {
        public static bool sendToEmail(BreachType breachType)
        {
            try
            {
                List<EmailAlertModel> emailAlertList = new List<EmailAlertModel>();
                XmlData xmlData = new XmlData();
                emailAlertList = xmlData.GetEmailAlertData();

                EmailAlertModel emailAlertData = emailAlertList.Where(t => t.BreachType == Convert.ToInt32(breachType)).FirstOrDefault();

                Console.WriteLine("To: {}\n", emailAlertData.Recipient);
                Console.WriteLine(emailAlertData.EmailMessage);

                return true;

            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
