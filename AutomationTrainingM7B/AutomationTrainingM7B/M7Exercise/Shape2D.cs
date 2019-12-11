using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Shape2D:IShape

    {
        public double dbleArea;
        public double dblePerimeter;
        public string StrName { get; set; }
        

        //METHOD FOR DISPLAYING INFORMATION
        public void DisplayInfo()
        {
            Console.WriteLine("The figure is: {0}", StrName);
            Console.WriteLine("This is the area {0} and this is the perimeter {1}", dbleArea, dblePerimeter);
        }

        //INITIALIZE ATTRIBUTES
        public Shape2D()
        {
            string strName = "";
            double dbleArea = 0;
            double dblePerimeter = 0;
        }

    }
}
