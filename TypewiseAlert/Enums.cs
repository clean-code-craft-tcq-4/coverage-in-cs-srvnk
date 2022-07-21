namespace TypewiseAlert
{
    public class Enums
    {
        public enum BreachType
        {
            TOO_LOW = 0,
            NORMAL = 1,
            TOO_HIGH = 2
        };
        public enum CoolingType
        {
            PASSIVE_COOLING = 0,
            MED_ACTIVE_COOLING = 1,
            HI_ACTIVE_COOLING = 2
        };
        public enum AlertTarget
        {
            TO_CONTROLLER,
            TO_EMAIL
        };
    }
}
