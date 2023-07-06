using Domain;
using Infrastructure;
using System.Xml;

namespace Application
{
    public class Weight_HeaderBs
    {

        private Weight_HeaderDb ObjDb = new Weight_HeaderDb();


        public bool Insert(XmlNode obj)
        {


            Weight_Header weight_Header = new Weight_Header();

            var childNodes = obj.ChildNodes[6].ChildNodes;

            weight_Header.DRY_OPERATING_WEIGHT = int.Parse(childNodes[0].InnerText);
            weight_Header.DRY_OPERATING_WEIGHT_UNIT = "";
            weight_Header.LOAD = int.Parse(childNodes[1].InnerText);
            weight_Header.ZERO_FUEL_WEIGHT_EW = int.Parse(childNodes[2].ChildNodes[0].InnerText);
            weight_Header.ZERO_FUEL_WEIGHT_SL = int.Parse(childNodes[2].ChildNodes[1].InnerText);
            weight_Header.TAKEOFF_EW = int.Parse(childNodes[3].ChildNodes[0].InnerText);
            weight_Header.TAKEOFF_OL = int.Parse(childNodes[3].ChildNodes[1].InnerText);
            weight_Header.TAKEOFF_SL = int.Parse(childNodes[3].ChildNodes[2].InnerText);
            weight_Header.TAKEOFF_REASON = "";
            weight_Header.LANDING_EW = int.Parse(childNodes[4].ChildNodes[0].InnerText);
            weight_Header.LANDING_OL = int.Parse(childNodes[4].ChildNodes[1].InnerText);
            weight_Header.LANDING_SL = int.Parse(childNodes[4].ChildNodes[2].InnerText);
            weight_Header.WEIGHT_HEADER_EXTENSION = childNodes[5].InnerText;
            weight_Header.LOAD_UNIT = "";

            int a = 0;
           
            ObjDb.Insert(weight_Header);

            return true;
        }
    }
}
