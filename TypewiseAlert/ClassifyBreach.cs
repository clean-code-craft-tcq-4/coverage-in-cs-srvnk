using System;
using System.Collections.Generic;
using System.Linq;
using static TypewiseAlert.Enums;

namespace TypewiseAlert
{
    public class ClassifyBreach
    {
        List<CoolingTypeModel> coolingList = new List<CoolingTypeModel>();
            XmlData xmlData = new XmlData();

            coolingList = xmlData.GetCoolingTypeData();

            CoolingTypeModel cooling = coolingList.Where(t => t.CoolingType == Convert.ToInt32(coolingType)).FirstOrDefault();

            return InferBreach.inferBreach(temperatureInC, cooling.LowerLimit, cooling.Upperlimit);
    }
}
