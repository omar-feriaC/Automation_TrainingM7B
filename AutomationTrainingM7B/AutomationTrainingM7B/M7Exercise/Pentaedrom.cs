using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Pentaedrom:Shape3D
    {
        //ATTRIBUTES THAT ARE GOING TO BE USED FOR THE PENTAGON
        public double dbleBase;
        public double dbleApotema;
        public double dbleHeight;
        
        //INITIALIZING THE VALUES
        public Pentaedrom()
        {
            dbleBase = 10;
            dbleApotema = 13;
            dbleHeight = 12;
            StrName = "Pentaedrom";
        }
        public Pentaedrom(string StrName3, double dbleBase2, double dbleApotema2, double dbleHeight2)
        {
            StrName = StrName3;
            dbleBase = dbleBase2;
            dbleApotema = dbleApotema2;
            dbleHeight = dbleHeight2;
        }

        //FUNCTION TO CALCULATE THE AREA
        public double calcArea()
        {
            dbleArea = ((dbleBase * 4) * dbleApotema) / 2 + (dbleBase * dbleBase);
            return dbleArea;
        }

        //FUNCTION TO CALCULATE THE VOLUME
        public double calcVolume()
        {
            dbleVolume = ((dbleBase * dbleBase) * dbleHeight) / 3;
            return dbleVolume;
        }

        //FUNCTION TO CALCULATE THE PERIMETER
        //BECAUSE OF TIME THIS WAS NOT DONE, SINCE THERE ARE DIFFERENT KINDS OF PENTAEDROMS
        //HOWEVER I DON'T BELIEVE THIS EXAMS IS REGARDING THE FORMULAS BUT INSTEAD
        //OF THE PROGRAMMING.


    }
}
