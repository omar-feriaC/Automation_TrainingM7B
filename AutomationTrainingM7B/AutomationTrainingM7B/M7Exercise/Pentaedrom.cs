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

        public double calcArea()
        {
            dbleArea = ((dbleBase * 4) * dbleApotema) / 2 + (dbleBase * dbleBase);
            return dbleArea;
        }

        public double calcVolume()
        {
            dbleVolume = ((dbleBase * dbleBase) * dbleHeight) / 3;
            return dbleVolume;
        }


    }
}
