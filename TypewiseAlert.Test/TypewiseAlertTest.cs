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
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 100));

            batteryCharacter.coolingType = CoolingType.MED_ACTIVE_COOLING;
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 100));

            batteryCharacter.coolingType = CoolingType.HI_ACTIVE_COOLING;
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER, batteryCharacter, 100));

            batteryCharacter.coolingType = CoolingType.PASSIVE_COOLING;
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 100));

            batteryCharacter.coolingType = CoolingType.MED_ACTIVE_COOLING;
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 100));

            batteryCharacter.coolingType = CoolingType.HI_ACTIVE_COOLING;
            batteryCharacter.brand = "BatteryBrand";

            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 0));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 25));
            Assert.True(TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL, batteryCharacter, 100));

        }
    }
}
