using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Manuel_Ku_M7_Exercise;


namespace AutomationTrainingM7B.Manuel_Ku_M7_Exercise
{
    public class _3D_Shape : IShape
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public double Base;
        public string Name;
        public double _Volume;
        public _3D_Shape()
        {
            Name = "Cube";
            Base = 0;
            Area = 0;
            Perimeter = 0;
            _Volume = 0;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine("Derived class 3D ",Name);
        }
    }
}
