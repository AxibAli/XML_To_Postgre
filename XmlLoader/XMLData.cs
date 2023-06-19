using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlLoader
{
    internal class XMLData
    {

        public void Data()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string folderPath = Path.Combine(currentDirectory, "XMLFile");

            if (Directory.Exists(folderPath))
            {

                // Reading the XML File
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(folderPath + "\\" + "MNMGKMIA-std.xml");
                XmlNode root = xmlDoc.DocumentElement;

                // Calling the Business Layer
                //Weight_HeaderBs weight_HeaderBs = new Weight_HeaderBs();
                //weight_HeaderBs.Insert(root);
                Airport_DatalistBs airport_DatalistBs = new Airport_DatalistBs();
                airport_DatalistBs.Insert(root);



            }
        }
    }
}
