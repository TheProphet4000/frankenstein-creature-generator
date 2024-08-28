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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowCreatures();
            Application.Run(new Interface()); //code after this doesn't work.. idk why
        }
        static void ShowCreatures() //makes an array and add a creature
        {
            string[] creatures = new string [5];
            for (int i = 0; i < creatures.Length; i++)
            {
                creatures[i] = CreatureGen.CreatureBase("Sharkman", "purple ");
                Debug.WriteLine(creatures[i]);
            }
            
        }
    }
}