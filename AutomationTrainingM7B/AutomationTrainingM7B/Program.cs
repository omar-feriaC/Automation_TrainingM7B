using AutomationTrainingM7B.M7Exercise;
using AutomationTrainingM7B.Page_Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            
            Square square = new Square(5, "Square");
            double area = square.fnArea();
            double perimeter = square.fnPer();
            double volume = square.fnVol();

            square.fnDisplayInfo();

            Cylinder cylinder = new Cylinder(5, "Cylinder", 10);
            double area2 = cylinder.fnArea();
            //double perimeter2 = cylinder.fnPer();
            double volume2 = cylinder.fnVol();

            cylinder.fnDisplayInfo3D();

            Console.ReadKey();
        }
    }
}
