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
        //OVERLOADING THE FUNCTION
        public Pentagon(string strPName, double dblePSide, double dblePApotema, double dblePHeight)
        {
            StrName = strPName;
            dbleSide = dblePSide;
            dbleApotema = dblePApotema;
            dbleHeight = dblePHeight;
        }

        //PERIMETER
        public double CalcPerimeter()
        {
            dblePerimeter = 5 * dbleSide;
            return dblePerimeter;
        }
        //OVERLOADING THE FUNCTION
        public double CalcPerimeter(double dbleSide2)
        {
            dblePerimeter = 5 * dbleSide2;
            return dblePerimeter;
        }


        //AREA
        public double CalcArea()
        {
            dbleArea = ((5 * dbleSide) * dbleApotema);
            return dbleArea;
        }
        //OVERLOADING THE FUNCTION
        public double CalcArea(double dbleSide3, double dbleApotema3)
        {
            dbleArea = ((5 * dbleSide3) * dbleApotema3);
            return dbleArea;
        }

        //VOLUME
        public double CalcVolume()
        {
            dbleVolume = (((5 * dbleSide) * dbleApotema) * dbleHeight);
            return dbleVolume;
        }
        //OVERLOADING THE FUNCTION
        public double CalcVolume(double dbleSide4, double dbleApotema2, double dbleHeight2)
        {
            dbleVolume = (((5 * dbleSide4) * dbleApotema2) * dbleHeight2);
            return dbleVolume;
        }
    }
}
