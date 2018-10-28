using System;
using System.Windows.Forms;

/*****************************************/
/*  Project 4:   Weather Today           */
/*  Author:      Lynn Eades              */
/*  Date:        10/28/2018              */
/*****************************************/

namespace WeatherApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
