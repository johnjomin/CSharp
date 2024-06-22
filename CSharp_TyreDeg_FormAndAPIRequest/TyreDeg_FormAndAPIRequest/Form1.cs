using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TyreDeg_FormAndAPIRequest
{
    public partial class Form1 : Form
    {
        public static string selectedFrontLeftTyre = "";
        public static string selectedFrontRightTyre = "";
        public static string selectedRearLeftTyre = "";
        public static string selectedRearRightTyre = "";
        public static double selectedCelsius;
        public static List<int> selectedTrackDegradation;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrganiseDropdownList();
            dropdownFrontLeft.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdownFrontRight.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdownRearLeft.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdownRearRight.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdownTrack.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void DropdownFrontLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Organising and calling methods for Tyre Dropdowns
        private void OrganiseDropdownList()
        {
            try
            {
                //Assigning Keys ie Tyre Names to List of strings
                List<string> frontLeft = new List<string>(getFrontLeftDict().Keys);
                List<string> frontRight = new List<string>(getFrontRightDict().Keys);
                List<string> rearLeft = new List<string>(getRearLeftDict().Keys);
                List<string> rearRight = new List<string>(getRearRightDict().Keys);

                List<string> trackLocationNames = getTrackLocationNames();

                //Populating Dropdown with Data
                dropdownFrontLeft.DataSource = frontLeft;
                dropdownFrontRight.DataSource = frontRight;
                dropdownRearLeft.DataSource = rearLeft;
                dropdownRearRight.DataSource = rearRight;
                dropdownTrack.DataSource = trackLocationNames;
            }
            catch (Exception e)
            {
                throw new Exception("Error in Organise Temperature and message is: " + e.Message);
            }
        }
        
        //Getting data from TrackDegradation Coefficient File
        private static List<string> getTrackLocationNames()
        {
            TrackDegradCoefConfig trackNames = new TrackDegradCoefConfig();
            return trackNames.TrackLocationNames();
        }

        private List<int> getTrackDegradationPoints()
        {
            TrackDegradCoefConfig trackNames = new TrackDegradCoefConfig();
            return trackNames.TrackDegradationPoints(dropdownTrack.Text);
        }


        //Getting data from Tyre Template Config xml file
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

        //Getting data from Weather API.cs 
        private WeatherAPI.root getWeatherData()
        {
            string cityName = dropdownTrack.SelectedItem.ToString();
            WeatherAPI weatherData = new WeatherAPI();
            return weatherData.DegreeCelsius(cityName);
        }

        private void TemperatureBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DropdownTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            var output = getWeatherData();
            temperatureBox.Text = string.Format("{0} \u00B0" + "C", output.main.temp);
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button1_Click(object sender, EventArgs e)
        {
            selectedFrontLeftTyre = dropdownFrontLeft.SelectedItem.ToString();
            selectedFrontRightTyre = dropdownFrontRight.SelectedItem.ToString();
            selectedRearLeftTyre = dropdownRearLeft.SelectedItem.ToString();
            selectedRearRightTyre = dropdownRearRight.SelectedItem.ToString();
            selectedCelsius = getWeatherData().main.temp;
            selectedTrackDegradation = getTrackDegradationPoints();

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
