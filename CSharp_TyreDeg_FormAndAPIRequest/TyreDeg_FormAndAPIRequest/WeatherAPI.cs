using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TyreDeg_FormAndAPIRequest
{
    public class WeatherAPI
    {
        //Getter and Setter methods to retrieva data from API
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
            public double gust { get; set; }
        }

        public class sys
        {
            public int type { get; set; }
            public double id { get; set; }
            public double message { get; set; }
            public string country { get; set; }
            public double sunrise { get; set; }
            public double sunset { get; set; }
        }

        public class root
        {
            public string name { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weatherList { get; set; }
            public coord coordinates { get; set; }

        }

        //Get or Retrieve data from weather API
        private WeatherAPI.root callWeatherAPI(string cityName)
        {
            const string APIKEY = "00de00fb067e141f266ecf6b31f2cd5e";

            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", cityName, APIKEY);

                    var json = web.DownloadString(url);

                    var result = JsonConvert.DeserializeObject<WeatherAPI.root>(json);

                    WeatherAPI.root output = result;

                    return output;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in Organise Temperature and message is: " + e.Message);
            }
        }

        
        //Ensuring the weather API works
        public WeatherAPI.root DegreeCelsius(string cityName)
        {
            try
            {
                WeatherAPI.root degree = callWeatherAPI(cityName);
                
                return degree;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while deserializing 'TyresXML.xml' to obtain a TyresTemplateConfig Template", e);
            }
        }

    }
}
