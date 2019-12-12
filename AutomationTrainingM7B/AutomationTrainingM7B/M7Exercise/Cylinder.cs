using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Cylinder : Shape3D
    {
        public double dblPi = 3.14;
        public double dblRad;
        public double dblAlt;


        //Constructor
        public Cylinder()
        {
            dblRad = 0;
            dblArea = 0;
            dblPerimeter = 0;
            dblVolume = 0;
            strName = "Cylinder";
        }

        //CONSTRUCTOR
        public Cylinder(double radio, string name, double height)
        {
            dblRad = radio;
            strName = name;
            dblAlt = height;
        }

        //METHOD Area
        public double fnArea()
        {
            dblArea = 2 * dblPi * dblRad * dblAlt;
            return dblArea;
        }

        /*/METHOD Perimeter
        public double fnPer()
        {
            dblArea = 2 * dblPi * dblRad * dblAlt;
            return dblArea;
        }*/

        //METHOD Volume
        public double fnVol()
        {
            dblVolume = dblPi * (dblRad * dblRad) * dblAlt;
            return dblVolume;
        }
    }
}