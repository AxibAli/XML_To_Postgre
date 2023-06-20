using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Application
{
    public class Airport_DatalistBs
    {

        private Airport_DatalistDb ObjDb = new Airport_DatalistDb();


        public bool Insert(XmlNode root)
        {
            foreach (XmlNode obj in root["AirportDataList"])
            {
                Airport_Datalist airport_Datalist = new Airport_Datalist();
                airport_Datalist.FUNCTION = obj.ChildNodes[0].Attributes[0].Value;
                airport_Datalist.NAME = obj.ChildNodes[0].Attributes[1].Value;
                airport_Datalist.ICAO_CODE = obj.ChildNodes[0].ChildNodes[0].InnerText;
                airport_Datalist.IATA_CODE = obj.ChildNodes[0].ChildNodes[1].InnerText;
                airport_Datalist.PLANNED_RUNWAY = obj.ChildNodes[1].InnerText;
                if (obj.ChildNodes[3].Name == "SuitablePeriod")
                {
                    airport_Datalist.SUITABLE_PER_FROM = DateTimeOffset.Parse(obj.ChildNodes[3].Attributes[0].Value);
                    airport_Datalist.SUITABLE_PER_UNTIL = DateTimeOffset.Parse(obj.ChildNodes[3].Attributes[1].Value);

                }
                else
                {
                    airport_Datalist.SUITABLE_PER_FROM = DateTime.Parse(obj.ChildNodes[4].Attributes[0].Value);
                    airport_Datalist.SUITABLE_PER_UNTIL = DateTime.Parse(obj.ChildNodes[4].Attributes[1].Value);

                }
                if (obj.ChildNodes[4].Name == "RequiredWeatherCondition")
                {
                    airport_Datalist.REQ_HOR_VISIBILITY = int.Parse(obj.ChildNodes[4].ChildNodes[0].InnerText);
                    airport_Datalist.REQ_VER_VISIBILITY = int.Parse(obj.ChildNodes[4].ChildNodes[1].InnerText);

                }
                else
                {
                    airport_Datalist.REQ_HOR_VISIBILITY = int.Parse(obj.ChildNodes[5].ChildNodes[0].InnerText);
                    airport_Datalist.REQ_VER_VISIBILITY = int.Parse(obj.ChildNodes[5].ChildNodes[1].InnerText);

                }
                if (obj.ChildNodes[5].Name == "ConsideredWeatherCondition")
                {
                    airport_Datalist.CON_HOR_VISIBILITY = int.Parse(obj.ChildNodes[5].ChildNodes[0].InnerText);
                    airport_Datalist.CON_VER_VISIBILITY = int.Parse(obj.ChildNodes[5].ChildNodes[1].InnerText);

                }
                else
                {
                    airport_Datalist.CON_HOR_VISIBILITY = int.Parse(obj.ChildNodes[6].ChildNodes[0].InnerText);
                    airport_Datalist.CON_VER_VISIBILITY = int.Parse(obj.ChildNodes[6].ChildNodes[1].InnerText);

                }
                ObjDb.Insert(airport_Datalist);
            }
            return true;
        }
    }
}
