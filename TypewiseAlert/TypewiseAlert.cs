using System;
using static TypewiseAlert.Enums;

namespace TypewiseAlert
{
    public class TypewiseAlert
    {
        public struct BatteryCharacter
        {
            public CoolingType coolingType;
            public string brand;
        }
        public static bool checkAndAlert(AlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC)
        {
            try
            {
                BreachType breachType = ClassifyBreach.classifyTemperatureBreach(batteryChar.coolingType, temperatureInC);

                if(alertTarget == AlertTarget.TO_CONTROLLER)
                {
                    return SendController.sendToController(breachType);
                }
                else
                {
                    return SendController.sendToEmail(breachType);
                }
            }
            catch(Exception)
            {
                return false;
            }            
        }
    }
}
