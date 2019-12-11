using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTrainingM7B.M7Exercise
{
    class Ellipse : _2D_Shape
    {
        public double PI = 3.1416;
        public double dbleRatio1;
        public double dbleRatio2;
        //public string strName;

        public Ellipse()
        {
            dbleArea = 0;
            dblePerimeter = 0;
            strName = "Ellipse";
            dbleRatio1 = 0;
            dbleRatio2 = 0;
        }

        public Ellipse(double pdbleRatio1, double pdbleRatio2)
        {
            strName = "Ellipse";
            dbleRatio1 = pdbleRatio1;
            dbleRatio2 = pdbleRatio2;
        }

        public double areaEllipse()
        {

            return dbleArea = dbleRatio1 * dbleRatio2 * PI;

        }

        public void areaEllipse(double pdbleRatio1, double pdbleRatio)
        {
            dbleArea = dbleRatio1 * dbleRatio2 * PI;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The area from the " + strName + " is " + dbleArea);
        }

    }
}
