using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class _2D_Shape : IShape
    {
        string IShape.strName { get; set; }
        double IShape.dbleArea { get; set; }
        double IShape.dblePerimeter { get; set; }

        protected string strName;
        protected double dbleArea;
        protected double dblePerimeter;

        public _2D_Shape()
        {
            strName = "";
            dbleArea = 0;
            dblePerimeter = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
        }

    }
}
