using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace BodySim
{
    internal static class Program
    {
        class Car
        {
            public static string model;
            public static string color;
            public static int year;

            public static Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine(Car.model);
        }
    }
}