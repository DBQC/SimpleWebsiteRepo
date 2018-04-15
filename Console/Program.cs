using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExampleDave();
            
            System.Console.WriteLine(Class1.something());
            System.Console.ReadKey();
        }

        private static void FirstExampleDave()
        {
            GradeBook davesGrades = new GradeBook();
            Stopwatch timer = Stopwatch.StartNew();
            davesGrades.AddGrade(5f);
            DateTime davesDate = new DateTime();
            timer.Stop();
            System.Console.WriteLine(davesGrades.Printgrades() + " " + timer.Elapsed);
            timer = Stopwatch.StartNew();
            FieldInfo prop = typeof(GradeBook).GetField("grades", (BindingFlags)int.MaxValue - 1);
            List<float> hack = new List<float>();
            hack.Add(10f);
            prop.SetValue(davesGrades, hack);
            timer.Stop();
            System.Console.WriteLine(davesGrades.Printgrades() + " " + timer.Elapsed);
            System.Console.WriteLine();
            System.Console.WriteLine(FlagColours.blue & (FlagColours)7);
            System.Console.ReadKey();
        }
    }
}
