using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class _2D_Shape:IShape

    {
        public double dbleArea { get; set; }
        public double dblPerimeter { get; set; }

        

        //METHOD FOR DISPLAYING INFORMATION
        public void DisplayInfo()
        {
            Console.WriteLine("This is the area {0} and this is the perimeter {1}", dbleArea, dblPerimeter);
        }

        //INITIALIZE ATTRIBUTES
        public _2D_Shape()
        {
            string strName = "";
            double dbleArea = 0;
            double dblPerimeter = 0;
        }

    }
}
