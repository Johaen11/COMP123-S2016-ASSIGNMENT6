using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_ASSIGNMENT6
{/**
        * @static
        * @method Main
        * @returns {void}
        */
    static class Program
    {
        // #1
        public static Form1 splashScreen;
        public static BMICalculator bmiCalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //#2
            splashScreen =  new Form1();

            //#3
            bmiCalculator = new BMICalculator();
           
            //Application.Run(new Form1());
            //Application.Run(bmiCalculator);
            Application.Run( splashScreen);
        }
    }
}
