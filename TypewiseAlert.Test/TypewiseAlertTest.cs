using System;
using Xunit;
using static TypewiseAlert.Enums;

namespace TypewiseAlert.Test
{
    public class TypewiseAlertTest
    {
        [Fact]
        public void TypewiseTest()
        {
            TypewiseAlert.BatteryCharacter batteryCharacter;
            batteryCharacter.coolingType = CoolingType.PASSIVE_COOLING;
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, -1).equals(true));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 30).equals(true));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 36).equals(true));
            
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, -1).equals(true));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 30).equals(true));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 36).equals(true));
        }
    }
}
