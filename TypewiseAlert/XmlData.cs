using System;
using System.Collections.Generic;
using System.Xml;

namespace TypewiseAlert
{
    public class XmlData
    {
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
            catch(Exception)
            {
                return null;
            }
        }

        public List<EmailAlertModel> GetEmailAlertData()
        {
            try
            {
                List<EmailAlertModel> emailAlertDataList = new List<EmailAlertModel>();
                EmailAlertModel emailAlertData = null;

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(string.Format("{0}/{1}", AppDomain.CurrentDomain.BaseDirectory, "EmailAlertFile.xml"));

                XmlNodeList nodeList = xmlDocument.DocumentElement.SelectNodes("/EmailAlertList/EmailAlert");

                if (nodeList != null && nodeList.Count > 0)
                {
                    foreach (XmlNode xmlNode in nodeList)
                    {
                        emailAlertData = new EmailAlertModel();
                        emailAlertData.BreachType = Convert.ToInt32(xmlNode.SelectSingleNode("BreachType").InnerText);
                        emailAlertData.BreachName = xmlNode.SelectSingleNode("BreachName").InnerText;
                        emailAlertData.Recipient = xmlNode.SelectSingleNode("Recipient").InnerText;
                        emailAlertData.EmailMessage = xmlNode.SelectSingleNode("EmailMessage").InnerText;

                        emailAlertDataList.Add(emailAlertData);
                    }
                }
                return emailAlertDataList;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
