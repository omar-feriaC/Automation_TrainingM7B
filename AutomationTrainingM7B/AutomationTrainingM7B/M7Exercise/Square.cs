using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Square: Shape3D
    {
        public double dblPi = 3.14;
        public double dblRad;


        //CONSTRUCTOR
        public Square()
        {
            dblRad = 0;
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
            strName = "Square";
        }

        //CONSTRUCTOR
        public Square (double radio, string name)
        {
            dblRad = radio;
            strName = name;
        }

        //METHOD Area
        public double fnArea()
        {
            dblArea = dblPi * (dblRad * dblRad);
            return dblArea;
        }

        //METHOD Perimeter
        public double fnPer()
        {
            dblPerimeter = 2 * dblPi * dblRad;
            return dblPerimeter;
        }

        //METHOD Volume
        public double fnVol()
        {
            dblVolume = (4/3) * dblPi * (dblRad * dblRad * dblRad );
            return dblVolume;
        }
    }
}
