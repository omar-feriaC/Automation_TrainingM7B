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
            _2D_Shape obj2D = new _2D_Shape();
            obj2D.DisplayInfo();

            _3D_Shape obj3D = new _3D_Shape();
            obj3D.DisplayInfo();




            Console.ReadKey();
        }
    }
}
