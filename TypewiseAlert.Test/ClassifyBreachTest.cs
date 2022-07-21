using System;
using Xunit;
using static TypewiseAlert.Enums;

namespace TypewiseAlert.Test
{
    class ClassifyBreachTest
    {
        public void ClassifyTemperatureBreachTest()
        {
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, -1) == BreachType.TOO_LOW);
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 31) == BreachType.NORMAL);
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 70) == BreachType.TOO_HIGH);

            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, -1) == BreachType.TOO_LOW);
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, 31) == BreachType.NORMAL);
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, 70) == BreachType.TOO_HIGH);

            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, -1) == BreachType.TOO_LOW);
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, 31) == BreachType.NORMAL);
            Assert.True(ClassifyBreach.classifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, 70) == BreachType.TOO_HIGH);
        }
    }
}
