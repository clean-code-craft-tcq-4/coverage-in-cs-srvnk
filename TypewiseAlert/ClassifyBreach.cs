using System;
using System.Collections.Generic;
using System.Linq;
using static TypewiseAlert.Enums;

namespace TypewiseAlert
{
    public class ClassifyBreach
    {
        public BreachType classifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
        {
            List<CoolingTypeModel> coolingList = new List<CoolingTypeModel>();
            XmlData xmlData = new XmlData();

            coolingList = xmlData.GetCoolingTypeData();

            CoolingTypeModel cooling = coolingList.Where(t => t.CoolingType == Convert.ToInt32(coolingType)).FirstOrDefault();

            return InferBreach.inferBreach(temperatureInC, cooling.LowerLimit, cooling.Upperlimit);
        }
        
        public List<CoolingTypeModel> GetCoolingTypeData()
        {
            try
            {
                List<CoolingTypeModel> coolingTypeList = new List<CoolingTypeModel>();
                CoolingTypeModel coolingType = null;

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(string.Format("{0}/{1}", AppDomain.CurrentDomain.BaseDirectory, "CoolingTypeFile.xml"));

                XmlNodeList nodeList = xmlDocument.DocumentElement.SelectNodes("/CoolingTypeList/CoolingType");

                if (nodeList != null && nodeList.Count > 0)
                {
                    foreach (XmlNode xmlNode in nodeList)
                    {
                        coolingType = new CoolingTypeModel();
                        coolingType.CoolingType = Convert.ToInt32(xmlNode.SelectSingleNode("CoolingType").InnerText);
                        coolingType.LowerLimit = Convert.ToDouble(xmlNode.SelectSingleNode("LowerLimit").InnerText);
                        coolingType.Upperlimit = Convert.ToDouble(xmlNode.SelectSingleNode("Upperlimit").InnerText);

                        coolingTypeList.Add(coolingType);
                    }
                }
                return coolingTypeList;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
