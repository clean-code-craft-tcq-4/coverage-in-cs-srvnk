using System;
using Xunit;
using System.Threading.Tasks;

namespace TypewiseAlert.Test
{
    class ControllerTest
    {
        public void SendControllerTest()
        {
            Assert.True(SendController.sendToController(Enums.BreachType.NORMAL));
            Assert.True(SendController.sendToController(Enums.BreachType.TOO_HIGH));
            Assert.True(SendController.sendToController(Enums.BreachType.TOO_LOW));
        }
    }
}
