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
            //
            double pR1;
            double pR2;
            Console.WriteLine("Ingresa el radio 1 para calcular el area de la elipse");
            pR1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el radio 2 para calcular el area de la elipse");
            pR2 = Convert.ToDouble(Console.ReadLine());

            Ellipse objEllipse = new Ellipse(pR1, pR2);
            objEllipse.areaEllipse();
            objEllipse.DisplayInfo();

            double pr;
            Console.WriteLine("Ingresa el radio para calcular el volumen de la esfera");
            pr = Convert.ToDouble(Console.ReadLine());

            Sphere objSphere = new Sphere(pr);
            objSphere.volumeSphere();
            objSphere.DisplayInfo();

            Console.ReadKey();
        }
    }
}
