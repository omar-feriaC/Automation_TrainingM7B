using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Sphere : _3D_Shape
    {
        public double PI = 3.1416;
        public double dbleRatio;
        public string strName;

        public Sphere()
        {
            dbleRatio = 0;
            strName = "Sphere";
        }

        public Sphere(double pdbleRatio)
        {
            PI = 3.1416;
            dbleRatio = pdbleRatio;
            strName = "Sphere";
        }

        public void volumeSphere()
        {
            dbleVolume = (4 * PI * (dbleRatio * dbleRatio * dbleRatio)) / 3;
        }

        public void volumeSphere(double pdbleRatio)
        {
            dbleVolume = (4 * PI * (dbleRatio * dbleRatio * dbleRatio)) / 3;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The volume from the " + strName + " is " + dbleVolume);
        }


    }
}
