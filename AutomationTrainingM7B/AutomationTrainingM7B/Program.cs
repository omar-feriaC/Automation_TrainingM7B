using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.M7Exercise;
using AutomationTrainingM7B.Manuel_Ku_M7_Exercise;
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice #1 \r\n");
            _2D_Shape obj2D = new _2D_Shape();
            obj2D.DisplayInfo();

            _3D_Shape obj3D = new _3D_Shape();
            obj3D.DisplayInfo();

            //Class object for Triangle
            Console.WriteLine("\r\n");
            Console.WriteLine("Exercice #2 \r\n");
            var objT = new Triangle(4, 4);
            Console.WriteLine("Triangle Area : {0} ", objT.GetArea());
            Console.WriteLine("Triangle Perimeter : {0} ", objT.GetPerimeter());

            //Class object for Cube
            var objC = new Cube(4);
            Console.WriteLine("Cube Area : {0} cm2", objC.GetCubeAreaTotal());
            Console.WriteLine("Cube Perimeter : {0} cm", objC.GetCubePerimeter());
            Console.WriteLine("Cube Volumem : {0} cm3", objC.GetCubeVolume());


            Console.ReadKey();
        }
    }
}
