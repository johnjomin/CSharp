using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace TyreDeg_FormAndAPIRequest
{
    //Mapping Tyres Collection
    [XmlRoot("Tyres")]
    public class TyresCollection
    {
        //[XmlArrayItem("Tyre", typeof(Tyre))]
        //public Tyre[] Tyre { get; set; }
        ////public List<Tyre> Metadata;
        [XmlElement("Tyre")]
        public List<Tyre> Tyre { get; set; }
    }

    //Mapping Tyres Array Items
    public class Tyre
    {
        [XmlElement("Name")]
        public string tyreName { get; set; }

        [XmlElement("Family")]
        public string tyreFamily { get; set; }

        [XmlElement("Type")]
        public string tyreType { get; set; }

        [XmlElement("Placement")]
        public string tyrePlacement { get; set; }

        [XmlElement("DegradationCoefficient")]
        public string tyreDegCoeff { get; set; }
    }

    //Methods to retrieve data from xml files
    public class TyresTemplateConfig
    {
        //Get or Read Xml file located under Debug Folder
        private TyresCollection readTyresTemplateConfig()
        {
            try
            {
                string filepath = "TyresXML.xml";
                TyresCollection tyres = null;
                XmlSerializer serializer = new XmlSerializer(typeof(TyresCollection));
                using (Stream reader = new FileStream(filepath, FileMode.Open))
                {
                    // Call the Deserialize method to restore the object's state.
                    tyres = (TyresCollection)serializer.Deserialize(reader);
                }
                if (tyres == null)
                    throw new Exception("The result of deserialization is a null TyresTemplateConfig Template object");

                return tyres;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while deserializing 'TyresXML.xml' to obtain a TyresTemplateConfig Template", e);
            }
        }

        //Ensure the retrival xml works
        public TyresCollection retrieveXML()
        {
            try
            {
                TyresCollection data = readTyresTemplateConfig();
                
                return data;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while adding data in FrontLeftData() and message is: ", e);
            }
        }

        //Read data from xml and collect information about front left tyre only
        public Dictionary<string, int> FrontLeftData()
        {
            try
            {
                var data = readTyresTemplateConfig();
                Dictionary<string, int> frontLeftDict = new Dictionary<string, int>();
                foreach (var configItem in data.Tyre)
                {
                    if (configItem.tyrePlacement == "FL")
                    {
                        frontLeftDict.Add(configItem.tyreName, Int32.Parse(configItem.tyreDegCoeff));
                    }
                }
                
                return frontLeftDict;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while adding data in FrontLeftData() and message is: ", e);
            }
        }

        //Read data from xml and collect information about front right tyre only
        public Dictionary<string, int> FrontRightData()
        {
            try
            {
                var data = readTyresTemplateConfig();
                Dictionary<string, int> frontRightDict = new Dictionary<string, int>();
                foreach (var configItem in data.Tyre)
                {
                    if (configItem.tyrePlacement == "FR")
                    {
                        frontRightDict.Add(configItem.tyreName, Int32.Parse(configItem.tyreDegCoeff));
                    }
                }

                return frontRightDict;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while adding data in FrontLeftData() and message is: ", e);
            }
        }

        //Read data from xml and collect information about rear left tyre only
        public Dictionary<string, int> RearLeftData()
        {
            try
            {
                var data = readTyresTemplateConfig();
                Dictionary<string, int> rearLeftDict = new Dictionary<string, int>();
                foreach (var configItem in data.Tyre)
                {
                    if (configItem.tyrePlacement == "FL")
                    {
                        rearLeftDict.Add(configItem.tyreName, Int32.Parse(configItem.tyreDegCoeff));
                    }
                }

                return rearLeftDict;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while adding data in FrontLeftData() and message is: ", e);
            }
        }

        //Read data from xml and collect information about rear right tyre only
        public Dictionary<string, int> RearRightData()
        {
            try
            {
                var data = readTyresTemplateConfig();
                Dictionary<string, int> rearRightDict = new Dictionary<string, int>();
                foreach (var configItem in data.Tyre)
                {
                    if (configItem.tyrePlacement == "FL")
                    {
                        rearRightDict.Add(configItem.tyreName, Int32.Parse(configItem.tyreDegCoeff));
                    }
                }

                return rearRightDict;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while adding data in FrontLeftData() and message is: ", e);
            }
        }
    }
}
