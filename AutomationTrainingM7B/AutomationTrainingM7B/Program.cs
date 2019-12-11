using AutomationTrainingM7B.Base_Files;
using AutomationTrainingM7B.M7Exercise.Alexis_Tun_M7_Exercise;
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
            double pSide;//Variable to insert the value of the Side of the Square
            double pHigh;
            //Objects to access to methods
            Shape_2D objShape_2D = new Shape_2D();
            Shape_3D objShape_3D = new Shape_3D();
            
            objShape_2D.DisplayInfo();
            objShape_3D.DisplayInfo();

            //Square class 2D
            Console.WriteLine("\n\n Please insert a numeric value for the Side: ");
            pSide = Convert.ToDouble(Console.ReadLine());
            Square objSquare = new Square(pSide);
            objSquare.DisplayInfo();


            //Square class 3D
            Console.WriteLine("\n\n Calculate the Volume of a prism with same Size of previous 2D shape");
            Console.WriteLine("\n Please insert a numeric value for the High of the prism: ");
            pHigh = Convert.ToDouble(Console.ReadLine());
            Prism objPrism = new Prism(pHigh,pSide);
            objPrism.DisplayInfo();

            Console.ReadKey();
        }
    }
}
