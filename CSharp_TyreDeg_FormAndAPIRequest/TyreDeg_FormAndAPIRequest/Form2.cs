using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyreDeg_FormAndAPIRequest
{
    public partial class Form2 : Form
    {
        PointTyreDegradationFormula pointTyreFormula = new PointTyreDegradationFormula();

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getPointDegradation();
        }

        private void getPointDegradation()
        {
            //Pass Selected Tyre Item
            pointTyreFormula.frontLeftTyreCoff = Form1.selectedFrontLeftTyre;
            pointTyreFormula.frontRightTyreCoff = Form1.selectedFrontRightTyre;
            pointTyreFormula.rearLeftTyreCoff = Form1.selectedRearLeftTyre;
            pointTyreFormula.rearRightTyreCoff = Form1.selectedRearRightTyre;

            pointTyreFormula.celsius = Form1.selectedCelsius;

            //Track Degradation Points
            pointTyreFormula.trackDegPoints = Form1.selectedTrackDegradation;

            pointTyreFormula.calculatePointTyreDegradation();
            assignAverageValues();
            assignModeValues();
            assignRangeValues();
        }

        public void assignAverageValues()
        {
            var averageFL = Math.Round(pointTyreFormula.pointTyreDegradationFL.Average());
            var averageFR = Math.Round(pointTyreFormula.pointTyreDegradationFR.Average());
            var averageRL = Math.Round(pointTyreFormula.pointTyreDegradationRL.Average());
            var averageRR = Math.Round(pointTyreFormula.pointTyreDegradationRR.Average());
            if (averageFL <= 999)
                frontLeftAverageResultBox.BackColor = Color.LightGreen;
            else if (averageFL >= 1000 && averageFL <= 2999)
                frontLeftAverageResultBox.BackColor = Color.Yellow;
            else if (averageFL >= 3000)
                frontLeftAverageResultBox.BackColor = Color.Red;

            if (averageFR <= 999)
                frontRightAverageResultBox.BackColor = Color.LightGreen;
            else if (averageFR >= 1000 && averageFR <= 2999)
                frontRightAverageResultBox.BackColor = Color.Yellow;
            else if (averageFR >= 3000)
                frontRightAverageResultBox.BackColor = Color.Red;

            if (averageRL <= 999)
                rearLeftAverageResultBox.BackColor = Color.LightGreen;
            else if (averageRL >= 1000 && averageRL <= 2999)
                rearLeftAverageResultBox.BackColor = Color.Yellow;
            else if (averageRL >= 3000)
                rearLeftAverageResultBox.BackColor = Color.Red;

            if (averageRR <= 999)
                rearRightAverageResultBox.BackColor = Color.LightGreen;
            else if (averageRR >= 1000 && averageRR <= 2999)
                rearRightAverageResultBox.BackColor = Color.Yellow;
            else if (averageRR >= 3000)
                rearRightAverageResultBox.BackColor = Color.Red;



            frontLeftAverageResultBox.Text = averageFL.ToString();
            frontRightAverageResultBox.Text = averageFR.ToString();
            rearLeftAverageResultBox.Text = averageRL.ToString();
            rearRightAverageResultBox.Text = averageRR.ToString();

        }

        public void assignModeValues()
        {
            var modeFL = Math.Round(pointTyreFormula.pointTyreDegradationFL.GroupBy(g => g).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault());
            var modeFR = Math.Round(pointTyreFormula.pointTyreDegradationFR.GroupBy(g => g).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault());
            var modeRL = Math.Round(pointTyreFormula.pointTyreDegradationRL.GroupBy(g => g).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault());
            var modeRR = Math.Round(pointTyreFormula.pointTyreDegradationRR.GroupBy(g => g).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault());

            if (modeFL <= 999)
                frontLeftModeResultBox.BackColor = Color.LightGreen;
            else if (modeFL >= 1000 && modeFL <= 2999)
                frontLeftModeResultBox.BackColor = Color.Yellow;
            else if (modeFL >= 3000)
                frontLeftModeResultBox.BackColor = Color.Red;

            if (modeFR <= 999)
                frontRightModeResultBox.BackColor = Color.LightGreen;
            else if (modeFR >= 1000 && modeFR <= 2999)
                frontRightModeResultBox.BackColor = Color.Yellow;
            else if (modeFR >= 3000)
                frontRightModeResultBox.BackColor = Color.Red;

            if (modeRL <= 999)
                rearLeftModeResultBox.BackColor = Color.LightGreen;
            else if (modeRL >= 1000 && modeRL <= 2999)
                rearLeftModeResultBox.BackColor = Color.Yellow;
            else if (modeRL >= 3000)
                rearLeftModeResultBox.BackColor = Color.Red;

            if (modeRR <= 999)
                rearRightModeResultBox.BackColor = Color.LightGreen;
            else if (modeRR >= 1000 && modeRR <= 2999)
                rearRightModeResultBox.BackColor = Color.Yellow;
            else if (modeRR >= 3000)
                rearRightModeResultBox.BackColor = Color.Red;

            frontLeftModeResultBox.Text = modeFL.ToString();
            frontRightModeResultBox.Text = modeFR.ToString();
            rearLeftModeResultBox.Text = modeRL.ToString();
            rearRightModeResultBox.Text = modeRR.ToString();
        }

        public void assignRangeValues()
        {
            var rangeFL = Math.Round(pointTyreFormula.pointTyreDegradationFL.Max(m => m) - pointTyreFormula.pointTyreDegradationFL.Min(m => m));
            var rangeFR = Math.Round(pointTyreFormula.pointTyreDegradationFR.Max(m => m) - pointTyreFormula.pointTyreDegradationFR.Min(m => m));
            var rangeRL = Math.Round(pointTyreFormula.pointTyreDegradationRL.Max(m => m) - pointTyreFormula.pointTyreDegradationRL.Min(m => m));
            var rangeRR = Math.Round(pointTyreFormula.pointTyreDegradationRR.Max(m => m) - pointTyreFormula.pointTyreDegradationRR.Min(m => m));

            if (rangeFL <= 999)
                frontLeftRangeResultBox.BackColor = Color.LightGreen;
            else if (rangeFL >= 1000 && rangeFL <= 2999)
                frontLeftRangeResultBox.BackColor = Color.Yellow;
            else if (rangeFL >= 3000)
                frontLeftRangeResultBox.BackColor = Color.Red;

            if (rangeFR <= 999)
                frontRightRangeResultBox.BackColor = Color.LightGreen;
            else if (rangeFR >= 1000 && rangeFR <= 2999)
                frontRightRangeResultBox.BackColor = Color.Yellow;
            else if (rangeFR >= 3000)
                frontRightRangeResultBox.BackColor = Color.Red;

            if (rangeRL <= 999)
                rearLeftRangeResultBox.BackColor = Color.LightGreen;
            else if (rangeRL >= 1000 && rangeRL <= 2999)
                rearLeftRangeResultBox.BackColor = Color.Yellow;
            else if (rangeRL >= 3000)
                rearLeftRangeResultBox.BackColor = Color.Red;

            if (rangeRR <= 999)
                rearRightRangeResultBox.BackColor = Color.LightGreen;
            else if (rangeRR >= 1000 && rangeRR <= 2999)
                rearRightRangeResultBox.BackColor = Color.Yellow;
            else if (rangeRR >= 3000)
                rearRightRangeResultBox.BackColor = Color.Red;

            frontLeftRangeResultBox.Text = rangeFL.ToString();
            frontRightRangeResultBox.Text = rangeFR.ToString();
            rearLeftRangeResultBox.Text = rangeRL.ToString();
            rearRightRangeResultBox.Text = rangeRR.ToString();
        }


    }
}
