using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyreDeg_FormAndAPIRequest
{
    public class PointTyreDegradationFormula
    {
        public List<int> trackDegPoints { get; set; }

        public double celsius { get; set; }

        public string frontLeftTyreCoff { get; set; }

        public string frontRightTyreCoff { get; set; }

        public string rearLeftTyreCoff { get; set; }

        public string rearRightTyreCoff { get; set; }

        public List<double> pointTyreDegradationFL = new List<double>();

        public List<double> pointTyreDegradationFR = new List<double>();

        public List<double> pointTyreDegradationRL = new List<double>();

        public List<double> pointTyreDegradationRR = new List<double>();

        public const int SuperSoftCoeffPercent = 80;

        public const int MediumCoeffPercent = 90;

        public const int HardCoeffPercent = 75;


        public void calculatePointTyreDegradation()
        {
            try
            {
                int frontLeftTyreCoffDigit = 0, frontRightTyreCoffDigit = 0, rearLeftTyreCoffDigit = 0, rearRightTyreCoffDigit = 0;
                var frontLeftDict = getFrontLeftDict();
                var frontRightDict = getFrontRightDict();
                var rearLeftDict = getRearLeftDict();
                var rearRightDict = getRearRightDict();

                //Please look at ReadME file for reasons to comment out this blocks/chunks of code. Thanks you :)
                foreach (var frontLeftItem in frontLeftDict)
                {
                    if (frontLeftTyreCoff == frontLeftItem.Key)
                    {
                        //if (frontLeftTyreCoff.Contains("SuperSoft"))
                        //{
                        //    frontLeftTyreCoffDigit = frontLeftItem.Value * SuperSoftCoeffPercent;
                        //    break;
                        //}
                        //else if (frontLeftTyreCoff.Contains("Medium"))
                        //{
                        //    frontLeftTyreCoffDigit = frontLeftItem.Value * MediumCoeffPercent;
                        //    break;
                        //}
                        //else if(frontLeftTyreCoff.Contains("Hard"))
                        //{
                        //    frontLeftTyreCoffDigit = frontLeftItem.Value * HardCoeffPercent;
                        //    break;
                        //}
                        //else
                        //{
                        //    frontLeftTyreCoffDigit = frontLeftItem.Value;
                        //    break;
                        //}
                        frontLeftTyreCoffDigit = frontLeftItem.Value;
                        break;
                    }
                }

                foreach (var frontRightItem in frontRightDict)
                {
                    if (frontRightTyreCoff == frontRightItem.Key)
                    {
                        //if (frontRightTyreCoff.Contains("SuperSoft"))
                        //{
                        //    frontRightTyreCoffDigit = frontRightItem.Value * SuperSoftCoeffPercent;
                        //    break;
                        //}
                        //else if (frontRightTyreCoff.Contains("Medium"))
                        //{
                        //    frontRightTyreCoffDigit = frontRightItem.Value * MediumCoeffPercent;
                        //    break;
                        //}
                        //else if (frontRightTyreCoff.Contains("Hard"))
                        //{
                        //    frontRightTyreCoffDigit = frontRightItem.Value * HardCoeffPercent;
                        //    break;
                        //}
                        //else
                        //{
                        //    frontRightTyreCoffDigit = frontRightItem.Value;
                        //    break;
                        //}
                        frontRightTyreCoffDigit = frontRightItem.Value;
                        break;
                    }
                }

                foreach (var rearLeftItem in rearLeftDict)
                {
                    if (rearLeftTyreCoff == rearLeftItem.Key)
                    {
                        //if (rearLeftTyreCoff.Contains("SuperSoft"))
                        //{
                        //    rearLeftTyreCoffDigit = rearLeftItem.Value * SuperSoftCoeffPercent;
                        //    break;
                        //}
                        //else if (rearLeftTyreCoff.Contains("Medium"))
                        //{
                        //    rearLeftTyreCoffDigit = rearLeftItem.Value * MediumCoeffPercent;
                        //    break;
                        //}
                        //else if (rearLeftTyreCoff.Contains("Hard"))
                        //{
                        //    rearLeftTyreCoffDigit = rearLeftItem.Value * HardCoeffPercent;
                        //    break;
                        //}
                        //else
                        //{
                        //    rearLeftTyreCoffDigit = rearLeftItem.Value;
                        //    break;
                        //}
                        rearLeftTyreCoffDigit = rearLeftItem.Value;
                        break;

                    }
                }

                foreach (var rearLeftItem in rearRightDict)
                {
                    if (rearRightTyreCoff == rearLeftItem.Key)
                    {
                        //if (rearRightTyreCoff.Contains("SuperSoft"))
                        //{
                        //    rearRightTyreCoffDigit = rearLeftItem.Value * SuperSoftCoeffPercent;
                        //    break;
                        //}
                        //else if (rearRightTyreCoff.Contains("Medium"))
                        //{
                        //    rearRightTyreCoffDigit = rearLeftItem.Value * MediumCoeffPercent;
                        //    break;
                        //}
                        //else if (rearRightTyreCoff.Contains("Hard"))
                        //{
                        //    rearRightTyreCoffDigit = rearLeftItem.Value * HardCoeffPercent;
                        //    break;
                        //}
                        //else
                        //{
                        //    rearRightTyreCoffDigit = rearLeftItem.Value;
                        //    break;
                        //}
                        rearRightTyreCoffDigit = rearLeftItem.Value;
                        break;
                    }
                }

                //Calculations being made for Point Tyre Degradation
                foreach (var trackPointItem in trackDegPoints)
                {
                    pointTyreDegradationFL.Add((trackPointItem * celsius) / frontLeftTyreCoffDigit);
                    pointTyreDegradationFR.Add((trackPointItem * celsius) / frontRightTyreCoffDigit);
                    pointTyreDegradationRL.Add((trackPointItem * celsius) / rearLeftTyreCoffDigit);
                    pointTyreDegradationRR.Add((trackPointItem * celsius) / rearLeftTyreCoffDigit);
                }
            }
            catch(Exception e)
            {
                throw new Exception("Error in calculatePointTyreDegradation() and message is:", e);
            }

        }

        //Getting data from Tyre Template Config xml file
        #region GetData from TyreXML file
        private static Dictionary<string, int> getFrontLeftDict()
        {
            TyresTemplateConfig tyreData = new TyresTemplateConfig();
            return tyreData.FrontLeftData();
        }

        private static Dictionary<string, int> getFrontRightDict()
        {
            TyresTemplateConfig tyreData = new TyresTemplateConfig();
            return tyreData.FrontRightData();
        }

        private static Dictionary<string, int> getRearLeftDict()
        {
            TyresTemplateConfig tyreData = new TyresTemplateConfig();
            return tyreData.RearLeftData();
        }

        private static Dictionary<string, int> getRearRightDict()
        {
            TyresTemplateConfig tyreData = new TyresTemplateConfig();
            return tyreData.RearRightData();
        }
        #endregion


    }
}
