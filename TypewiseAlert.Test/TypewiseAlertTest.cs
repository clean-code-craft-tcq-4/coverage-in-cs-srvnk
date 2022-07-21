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
            Assert.True(InferBreach.inferBreach(12, 20, 30) == BreachType.TOO_LOW);
            Assert.True(InferBreach.inferBreach(0, 20, 30) == BreachType.TOO_LOW);
            Assert.True(InferBreach.inferBreach(6, 20, 30) == BreachType.TOO_LOW);

            Assert.True(InferBreach.inferBreach(25, 20, 30) == BreachType.NORMAL);
            Assert.True(InferBreach.inferBreach(28, 20, 30) == BreachType.NORMAL);
            Assert.True(InferBreach.inferBreach(22, 20, 30) == BreachType.NORMAL);

            Assert.True(InferBreach.inferBreach(40, 20, 30) == BreachType.TOO_HIGH);
            Assert.True(InferBreach.inferBreach(50, 20, 30) == BreachType.TOO_HIGH);
            Assert.True(InferBreach.inferBreach(100, 20, 30) == BreachType.TOO_HIGH);
        }
    }
}
