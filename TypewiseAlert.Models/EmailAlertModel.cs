using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypewiseAlert.Models
{
    public class EmailAlertModel
    {
        public string Recipient { get; set; }
        public int BreachType { get; set; }
        public string BreachName { get; set; }
        public string EmailMessage { get; set; }
    }
}
