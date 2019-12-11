using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Manuel_Ku_M7_Exercise
{
    public class Triangle : _2D_Shape
    {      
        public double Base { get; set; }
        public double Altura { get; set; }  

        public Triangle()// Inicialization
        {
            Base = 0;
            Altura = 0;
            Area = 0;
            Perimeter = 0;
            Name = "Triangle";           
        }
        public Triangle(double bT, double aT)//Value Assignment
        {
            Base = bT;
            Altura = aT;           
        }
        public double GetArea()// Area = (b.h) / 2
        {            
            double Area;            
            return Area= Base*Altura / 2;           
        }
        public double GetPerimeter()//Equilateral triangle Perimeter = a + b + c
        {
            double Perimeter;
            return Perimeter = Base + Base + Base;
        }


    }
}
