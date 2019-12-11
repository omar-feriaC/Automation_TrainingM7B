using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Pentagon:Shape3D
    {
        //ATTRIBUTES THAT ARE GOING TO BE USED FOR THE PENTAGON
        public double dbleSide;
        public double dbleApotema;
        public double dbleHeight;

        //INITIALIZING THE VALUES
        public Pentagon()
        {
            dbleSide = 3;
            dbleApotema = 2;
            dbleHeight = 3;
            StrName = "Pentagon";
        }

        //PERIMETER
        public double CalcPerimeter()
        {
            dblePerimeter = 5 * dbleSide;
            return dblePerimeter;
        }

        //AREA
        public double CalcArea()
        {
            dbleArea = ((5 * dbleSide) * dbleApotema);
            return dbleArea;
        }

        //VOLUME
        public double CalcVolume()
        {
            dbleVolume = (((5 * dbleSide) * dbleApotema) * dbleHeight);
            return dbleVolume;
        }
    }
}
