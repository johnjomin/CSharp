using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TyreDeg_FormAndAPIRequest;

namespace UnitTestTyreDeg_FormAndAPIRequest
{
    [TestClass]
    public class TyresTemplateConfigTests
    {
        [TestMethod]
        public void RetrievalXML_ReturnsTrueORFalse()
        {
            //Arrange
            var xml = new TyresTemplateConfig();

            //Act
            var xmlRetrieval = xml.retrieveXML();
            bool retrieval = false;
            if (xmlRetrieval.GetType() == typeof(TyresCollection))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This retrieveXML method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This retrieveXML method does not works as intended");
            }
        }

        [TestMethod]
        public void RetrievalFrontLeftDataviaXML_ReturnsTrueORFalse()
        {
            //Arrange
            var xml = new TyresTemplateConfig();

            //Act
            var frontleftdata = xml.FrontLeftData();
            bool retrieval = false;
            if (frontleftdata.GetType() == typeof(Dictionary<string, int>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This FrontLeftData method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This FrontLeftData method does not works as intended");
            }
        }

        [TestMethod]
        public void RetrievalFrontRightDataviaXML_ReturnsTrueORFalse()
        {
            //Arrange
            var xml = new TyresTemplateConfig();

            //Act
            var frontrightdata = xml.FrontRightData();
            bool retrieval = false;
            if (frontrightdata.GetType() == typeof(Dictionary<string, int>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This FrontLeftData method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This FrontLeftData method does not works as intended");
            }
        }

        [TestMethod]
        public void RetrievalRearLeftDataviaXML_ReturnsTrueORFalse()
        {
            //Arrange
            var xml = new TyresTemplateConfig();

            //Act
            var rearleftdata = xml.RearLeftData();
            bool retrieval = false;
            if (rearleftdata.GetType() == typeof(Dictionary<string, int>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This FrontLeftData method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This FrontLeftData method does not works as intended");
            }
        }

        [TestMethod]
        public void RetrievalRearRightDataviaXML_ReturnsTrueORFalse()
        {
            //Arrange
            var xml = new TyresTemplateConfig();

            //Act
            var rearrightdata = xml.RearRightData();
            bool retrieval = false;
            if (rearrightdata.GetType() == typeof(Dictionary<string, int>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This FrontLeftData method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This FrontLeftData method does not works as intended");
            }
        }
    }
}
