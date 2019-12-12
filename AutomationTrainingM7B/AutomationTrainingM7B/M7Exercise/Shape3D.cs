using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.M7Exercise;

namespace AutomationTrainingM7B.M7Exercise
{
    class Shape3D : Shape2D
    {
        public double dblVolume;

        public void fnDisplayInfo3D()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Volume: " + dblVolume);
            Console.WriteLine("");
        }

        public Shape3D()
        {
            strName = "";
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
        }
    }
}
