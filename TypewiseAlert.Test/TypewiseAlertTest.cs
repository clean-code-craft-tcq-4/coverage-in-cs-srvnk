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

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, -1));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 30));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 36));
            
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, -1));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 30));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 36));

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
