using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypewiseAlert.Manager;
using TypewiseAlert.Models;
using static TypewiseAlert.Enums;

namespace TypewiseAlert
{
    public class ClassifyBreach
    {
        public static BreachType classifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
        {
            List<CoolingTypeModel> coolingTypeList = new List<CoolingTypeModel>();
            CoolingTypeModel cooling = new CoolingTypeModel();
            XmlData xmlData = new XmlData();

            coolingTypeList = xmlData.GetCoolingTypeData();

            cooling = coolingTypeList.Where(t => t.CoolingType == Convert.ToInt32(coolingType)).FirstOrDefault();

            return InferBreach.inferBreach(temperatureInC, cooling.LowerLimit, cooling.Upperlimit);
        }
    }
}
