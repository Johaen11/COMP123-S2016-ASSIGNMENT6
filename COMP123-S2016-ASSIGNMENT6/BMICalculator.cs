using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_ASSIGNMENT6
{
    public partial class BMICalculator : Form
    {
        bool isMetricUnits;
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            MetricUnitsRadioButton.Checked = true;
        }

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
                HeightUnitLabel.Text = "Cm";
                isMetricUnits = true;
            }
        }

        private void BMIButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double bmi = weight/(height * height);
            if(!isMetricUnits)
            {
                bmi *= 703;
                
                if(bmi <= 18.5)
                {
                    ResultsTextBox.Text = "Underweight";
                   
                }
                else if (bmi >= 18.5 && bmi<= 24.9 )
                {
                    ResultsTextBox.Text = "Normal";

                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    ResultsTextBox.Text = "Overweight";
                }
                else
                {
                    ResultsTextBox.Text = "Obese";
                }

            }
            BMITextBox.Text = bmi.ToString();
            
        }

        private void ResultsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
