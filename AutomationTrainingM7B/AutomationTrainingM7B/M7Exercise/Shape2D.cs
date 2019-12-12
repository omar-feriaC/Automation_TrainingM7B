using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.M7Exercise;

namespace AutomationTrainingM7B.M7Exercise
{
    class Shape2D : IShape
    {
        //IShape ishape;

        public double dblArea;
        public double dblPerimeter;

        public string strName { get; set; }

        public void fnDisplayInfo()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + dblArea);
            Console.WriteLine("Perimeter: " + dblPerimeter);
            Console.WriteLine("");
        }

        public void DisplayInfo(string strName)
        {
            throw new NotImplementedException();
        }

        public Shape2D()
        {
            strName = "";
            dblArea = 0;
            dblPerimeter = 0;
        }
    }
}