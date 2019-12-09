using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    interface IShape
    {
        /*ATTRIBUTES*/
        public static double dbleArea;
        public static double dblePerimeter;

        public void DisplayInfo()
        {
            Console.WriteLine(DblArea);
            Console.WriteLine(DblPerimeter);
        }
    }
}
