using AutomationTrainingM7B.Base_Files;
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
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("                         EXERCISE THAT IS A QUIZZ BUT IS NOT A QUIZZ BUT IF I FAIL I WONT PASS");
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("");
            Pentagon pentagon = new Pentagon();
            pentagon.CalcArea();
            pentagon.CalcPerimeter();
            pentagon.CalcVolume();
            pentagon.DisplayInfo();
            pentagon.displayInfo3();
            Console.WriteLine("");
            Pentaedrom pentaedrom = new Pentaedrom();
            pentaedrom.calcArea();
            pentaedrom.calcVolume();
            pentaedrom.DisplayInfo();
            pentaedrom.displayInfo3();
            Console.WriteLine("");
            Pentagon Ppentagon = new Pentagon("New Parametric Pentagon", 3, 4, 5);
            Ppentagon.CalcArea();
            Ppentagon.CalcPerimeter();
            Ppentagon.CalcVolume();
            Ppentagon.DisplayInfo();
            Ppentagon.displayInfo3();
            Console.WriteLine("");
            Pentaedrom Ppentaedrom = new Pentaedrom("New Parametric Pentaedrom", 3, 4, 5);
            Ppentaedrom.calcArea();
            Ppentaedrom.calcVolume();
            Ppentaedrom.DisplayInfo();
            Ppentaedrom.displayInfo3();



            Console.ReadKey();
        }
    }
}
