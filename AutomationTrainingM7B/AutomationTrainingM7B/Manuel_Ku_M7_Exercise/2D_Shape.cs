using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Manuel_Ku_M7_Exercise;

namespace AutomationTrainingM7B.Manuel_Ku_M7_Exercise
{

    public class _2D_Shape : IShape
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public string Name;

        public _2D_Shape()//Class contructor inicialized attributes
        {
            Area = 0;
            Perimeter = 0;
            Name = "Triangle";           
        }
        public void DisplayInfo()
        {
            Console.WriteLine("From class 2D_Shape",Name);
        }
    }

}
