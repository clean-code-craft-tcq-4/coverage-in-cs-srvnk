using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
