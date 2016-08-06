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

namespace COMP123_S2016_ASSIGNMENT6
{
    public partial class Form1 : Form
    {
      // public BMICalculator bmiCalc = Program.bmiCalculator;

        public Form1()
        {
            InitializeComponent();
            //bmiCalc = new BMICalculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////this.Hide();
            //bmiCalc.Show();
            //Program.splashScreen.Hide();

            // if this was in bmicalculator.cs
            // this = bmi calculator
            // splashScreen = form1
            //in the load method
            //splashscreen.show, this.hide
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Program.bmiCalculator.Show();
           // bmiCalc.Show();
            this.Hide();

            // each tick occurs every 1 second
            //numberOfSecondsPassed++;
            //if (numberOfSecondsPassed == 3)
            //{
            //    bmiCalc.Close();
            //    Program.splashScreen.Show();
            //    // if this was in bmicalculator.cs
            //    // this = bmi calculator
            //    // splashScreen = form1
            //    //in this seconds checker, when secs = 3s
            //    //splashscreen.close
            //    //this.show
            //}
        }
    }
}
