using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TyreDeg_FormAndAPIRequest;

namespace UnitTestTyreDeg_FormAndAPIRequest
{
    [TestClass]
    public class WeatherAPIUnitTests
    {
        [TestMethod]
        public void RetrievalDegreeCelsius_ReturnsTrueORFalse()
        {
            //Arrange
            WeatherAPI fileTxt = new WeatherAPI();

            //Act
            var celsiusRetrieval = fileTxt.DegreeCelsius("Towcester");
            bool retrieval = false;
            if (celsiusRetrieval.GetType() == typeof(WeatherAPI.root))
            {
                retrieval = true;
                Assert.IsTrue(retrieval, "This TrackName method works as intended");
            }
            else
            {
                Assert.IsTrue(retrieval, "This TrackName method does not works as intended");
            }
        }
    }
}
