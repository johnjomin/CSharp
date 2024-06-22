using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TyreDeg_FormAndAPIRequest
{
    public class TrackDegradCoefConfig
    {
        //Get Track names
        public List<string> TrackNames()
        {
            try
            {
                var lines = readTrackDegradationCoefficient();
                List<string> tracksNames = new List<string>();

                foreach (string line in lines)
                {
                    string track = line.Split('|')[0];
                    tracksNames.Add(track);
                }
                return tracksNames;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while deserializing 'TyresXML.xml' to obtain a TyresTemplateConfig Template", e);
            }
        }

        //Get Track location Names
        public List<string> TrackLocationNames()
        {
            try
            {
                var lines = readTrackDegradationCoefficient();
                List<string> tracksNames = new List<string>();

                foreach (string line in lines)
                {
                    string track = line.Split('|')[1];
                    tracksNames.Add(track);
                }
                return tracksNames;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while deserializing 'TyresXML.xml' to obtain a TyresTemplateConfig Template", e);
            }
        }

        //Get Track Degradation Points on each Location/Track
        public List<int> TrackDegradationPoints(string locationName)
        {
            try
            {
                var lines = readTrackDegradationCoefficient();
                List<int> trackDegPoint = new List<int>();

                foreach (string line in lines)
                {
                    string[] track = line.Split('|');
                    if(locationName == track[1])
                    {
                        string[] points = track[2].Split(',');
                        foreach(string point in points)
                        {
                            var convert = Int32.Parse(point);
                            trackDegPoint.Add(convert);
                        }
                    }
                }
                return trackDegPoint;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while deserializing 'TyresXML.xml' to obtain a TyresTemplateConfig Template", e);
            }
        }

        //Ensure the retrieval is working
        public string[] retrievalDegCoff()
        {
            var retrieveFilePath = readTrackDegradationCoefficient();

            return retrieveFilePath;
        }

        //Get Or Read Track Degradataion text file
        private string[] readTrackDegradationCoefficient()
        {
            var filepath = "TrackDegradationCoefficients.txt";
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                return lines;
            }
            catch (Exception e)
            {
                throw new Exception($"Error while deserializing 'TyresXML.xml' to obtain a TyresTemplateConfig Template", e);
            }
        }
    }
}
