using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;
using System.Diagnostics; //for test purposes, delete later

namespace BodySim
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ShowCreatures();
            Application.Run(new Form1()); //code after this doesn't work.. idk why
        }

        /*
        static void ShowCreatures() //make an array and add creatures from a contructor called CreatureGen
        {
            object[] creatures;

            for (int i = 0; i < 2; i++)
            {
                creatures[i] = new CreatureGen("Sharkman", "red");
            }
        }
        */


        //GPTs answer below
        public class ObjectArray
        {
            public object[] Creatures { get; private set; }

            public ObjectArray(params object[] creatures)
            {
                Creatures = new object[creatures.Length];
                for (int i = 0; i < creatures.Length; i++)
                {
                    Creatures[i] = creatures[i];
                }
            }
            public void PrintObjects()
            {
                foreach (var obj in Creatures)
                {
                    Debug.WriteLine(obj);
                }
            }
        }
    }
}