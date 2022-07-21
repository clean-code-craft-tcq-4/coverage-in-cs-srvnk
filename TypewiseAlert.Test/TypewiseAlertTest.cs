using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TypewiseAlert.Enums;

namespace TypewiseAlert.Test
{
    public class TypewiseAlertTest
    {
        public void TypewiseTest()
        {
            TypewiseAlert.BatteryCharacter batteryCharacter;
            batteryCharacter.coolingType = CoolingType.PASSIVE_COOLING;

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 100));
            
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 24));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 99));

            batteryCharacter.coolingType = CoolingType.MED_ACTIVE_COOLING;

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 5));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 30));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 90));
            
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 6));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 26));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 98));

            batteryCharacter.coolingType = CoolingType.HI_ACTIVE_COOLING;

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 2));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 32));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 94));
            
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 8));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 39));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 87));
        }
    }
}
