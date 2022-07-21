using System;
using Xunit;
using System.Threading.Tasks;

namespace TypewiseAlert.Test
{
    class EmailTest
    {
        public void SendEmailTest()
        {
            Assert.True(SendEmail.sendToEmail(Enums.BreachType.NORMAL));
            Assert.True(SendEmail.sendToEmail(Enums.BreachType.TOO_HIGH));
            Assert.True(SendEmail.sendToEmail(Enums.BreachType.TOO_LOW));
        }
    }
}
