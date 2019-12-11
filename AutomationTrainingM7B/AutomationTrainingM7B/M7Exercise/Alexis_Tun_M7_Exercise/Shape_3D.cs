using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise.Alexis_Tun_M7_Exercise
{
    class Shape_3D : Shape_2D
    {
        protected double dblVolume;

        public double area { get; set; }
        public double perimeter { get ; set; }
        public string name { get; set; }
        public string volume { get; set; }



        public Shape_3D()
        {
            strName = "Square";
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Information from 3D Shape: \n Name={strName} \n Volume= {dblVolume}");
        }

    }
}
