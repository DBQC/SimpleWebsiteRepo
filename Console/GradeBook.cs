using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class GradeBook
    {
        private List<float> grades;
        public GradeBook()
        {
            grades = new List<float>();
        }
        

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public float Printgrades()
        {
            foreach (float grade in grades)
            {
                return grade;
            }
            return 0f;
        }


    }
    [Flags]
    public enum FlagColours
    {
        white = (1 << 0),
        red = (1 << 1),
        blue = (1 << 2),
        green = (1 << 3),
        black = (1 << 4)
    }
}
