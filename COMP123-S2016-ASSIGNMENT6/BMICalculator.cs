using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2016_ASSIGNMENT6;

/**
 * Author: Johaen Gnanakumar
 * Date: August 05, 2016
 * StudentID: 300880309
 * Description: A BMI Calculator that has both imperial and metric values.
 * Version: 0.04
 */
namespace COMP123_S2016_ASSIGNMENT6
{       


    public partial class BMICalculator : Form
    {
        bool isMetricUnits;
       //Form1 splashScreen;
        //int numberOfMillisecondsPassed;


        public BMICalculator()
        {
            InitializeComponent();
            //splashScreen = new Form1();
            //numberOfMillisecondsPassed = 0;
        }
        /**
         * <summary>
         * This Method calls 
         * </summary>
         * 
         * @static
         * @method BMICalculator
         * 
         * @returns {void}
         */
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            //splashScreen.Show();
            //this.Visible = false;
            MetricUnitsRadioButton.Checked = true;
        }
         /**
         * <summary>
         * This method displays the menu using a while loop
         * </summary>
         * 
         * @static
         * @method 
         * 
         * @returns {void}
         */
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tempButton = (RadioButton)sender;
            if(tempButton == ImperialUnitsRadioButton)
            {
                WeightUnitLabel.Text = "Lbs";
                HeightUnitLabel.Text = "In";
                isMetricUnits = false;
            }
            else
            {
                WeightUnitLabel.Text = "Kg";
                HeightUnitLabel.Text = "M";
                isMetricUnits = true;
            }
        }
         /**
         * <summary>
         * This method displays 
         * </summary>
         * 
         * @static
         * @method 
         * 
         * @returns {void}
         * 
         */ 
        private void BMIButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double bmi = weight/(height * height);
            if(!isMetricUnits)
            {
                bmi *= 703;
              
            }
            if (bmi <= 18.5)
            {
                ResultsTextBox.Text = "Underweight";
                progressBar1.Value = Convert.ToInt32(18.5);

            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                ResultsTextBox.Text = "Normal";
                progressBar1.Value = Convert.ToInt32(bmi);

            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                ResultsTextBox.Text = "Overweight";
                progressBar1.Value = Convert.ToInt32(bmi);
            }
            else
            {
                ResultsTextBox.Text = "Obese";
                progressBar1.Value = 30;
            }
            BMITextBox.Text = bmi.ToString();
            
        }
         /**
         * <summary>
         * This method displays the menu
         * </summary>
         * 
         * @static
         * @method 
         * 
         * @returns {void}
         */ 
        private void ResultsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMITextBox.Text = "";
            ResultsTextBox.Text = "";
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMITableLabel_Click(object sender, EventArgs e)
        {

        }

        private void BMICalculatorTimer_Tick(object sender, EventArgs e)
        {
            //// each tick occurs every  0.1 seconds
            //numberOfMillisecondsPassed+=100;

            ////show splash screen after 0.1 seconds of form loading
            //if (numberOfMillisecondsPassed == 100)
            //{
            //    splashScreen.Show();
            //}

            //// 3 seconds after splash screen showed up
            //if (numberOfMillisecondsPassed == 3100)
            //{
            //    splashScreen.Close();
            //}
        }
    }
}
