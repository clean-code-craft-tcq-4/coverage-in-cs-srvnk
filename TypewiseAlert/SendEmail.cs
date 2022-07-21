using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypewiseAlert.Manager;
using TypewiseAlert.Models;
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
                EmailAlertModel emailAlertData = new EmailAlertModel();
                XmlData xmlData = new XmlData();
                emailAlertList = xmlData.GetEmailAlertData();

                emailAlertData = emailAlertList.Where(t => t.BreachType == Convert.ToInt32(breachType)).FirstOrDefault();

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
