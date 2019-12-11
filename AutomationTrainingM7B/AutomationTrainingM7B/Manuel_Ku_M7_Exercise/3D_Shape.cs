using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Manuel_Ku_M7_Exercise;


namespace AutomationTrainingM7B.Manuel_Ku_M7_Exercise
{
    public class _3D_Shape : _2D_Shape // Needs to inherits from 2d
    {
        public double Base;
        public new string Name;
        public double Volume;
        public _3D_Shape()
        {
            Name = "Cube";
            Base = 0;
            Area = 0;
            Perimeter = 0;
            Volume = 0;
        }
        public new void DisplayInfo()
        {
            Console.WriteLine("From class 3D ", Name);
        }
    }
   
}
