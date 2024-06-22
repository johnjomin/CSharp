using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TyreDeg_FormAndAPIRequest;

namespace UnitTestTyreDeg_FormAndAPIRequest
{
    [TestClass]
    public class TrackDegradationCoefficientConfigUnitTests
    {
        [TestMethod]
        public void RetrievalTxt_ReturnsTrue()
        {
            //Arrange
            var fileTxt = new TrackDegradCoefConfig();

            //Act
            var txtRetrieval = fileTxt.retrievalDegCoff();

            bool isRetrievalTXT = txtRetrieval is string[];

            //Assert
            Assert.IsTrue(isRetrievalTXT);
        }

        [TestMethod]
        public void RetrievalTrackNames_ReturnsTrueORFalse()
        {
            //Arrange
            var fileTxt = new TrackDegradCoefConfig();

            //Act
            var txtRetrieval = fileTxt.TrackNames();
            bool retrieval = false;
            if(txtRetrieval.GetType() == typeof(List<string>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This TrackName method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This TrackName method does not works as intended");
            }
        }

        [TestMethod]
        public void RetrievalTrackLocation_ReturnsTrueORFalse()
        {
            //Arrange
            var fileTxt = new TrackDegradCoefConfig();

            //Act
            var txtRetrieval = fileTxt.TrackLocationNames();
            bool retrieval = false;
            if (txtRetrieval.GetType() == typeof(List<string>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This TrackLocationNames method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This TrackLocationNames method does not works as intended");
            }
        }

        [TestMethod]
        public void RetrievalTrackDegradationPoints_ReturnsTrueORFalse()
        {
            //Arrange
            var fileTxt = new TrackDegradCoefConfig();

            //Act
            var txtRetrieval = fileTxt.TrackDegradationPoints("Towcester");
            bool retrieval = false;
            if (txtRetrieval.GetType() == typeof(List<int>))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This TrackDegradationPoints method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This TrackDegradationPoints method does not works as intended");
            }
        }
    }
}
