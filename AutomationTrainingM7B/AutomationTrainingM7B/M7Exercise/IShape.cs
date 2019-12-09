using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    interface IShape 
    {
        //Attributs for Area and Perimeter
        public static double dbleArea;
        public static double dblePerimeter;

        //Method to print the Attributes
        public void DisplayInfo()
        {
            Console.WriteLine("This is the area {0} and this is the perimeter {1}", dbleArea, dblePerimeter)
        }
    }
}
