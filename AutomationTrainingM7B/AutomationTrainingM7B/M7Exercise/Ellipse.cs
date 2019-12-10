using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTrainingM7B.M7Exercise
{
    class Ellipse : _2D_Shape
    {

        public void _2D_Shape()
        {
            dbleBase = 4;
            dbleHigh = 5;
            dbleArea = dbleBase * dbleHigh;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The area from the Ellipse is"+ dbleArea);
        }

    }
}
