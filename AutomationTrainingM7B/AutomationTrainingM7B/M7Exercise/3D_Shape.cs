using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class _3D_Shape : IShape
    {
        public double dbleArea { get; set; }
        public double dblePerimeter { get; set; }
        public double dbleVolume { get; set; }
        public string strName { get; set; }
        public double dbleBase { get; set; }
        public double dbleHigh { get; set; }

        public _3D_Shape()
        {
            strName = "";
            dbleArea = 0;
            dblePerimeter = 0;
            dbleVolume = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
        }
    }
}
