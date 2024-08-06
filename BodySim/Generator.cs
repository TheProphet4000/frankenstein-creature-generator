using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;
using System.Diagnostics;

namespace BodySim
{
    internal static class Generator
    {
        static string[] creatures;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowCreatures();
            Application.Run(new Form1()); //code after this doesn't work.. idk why
        }
        static void ShowCreatures() //make an array and add a creature
        {
            string gen = CreatureGen.CreatureBase("Sharkman", "purple ");
            Debug.WriteLine(gen);
        }
    }
}