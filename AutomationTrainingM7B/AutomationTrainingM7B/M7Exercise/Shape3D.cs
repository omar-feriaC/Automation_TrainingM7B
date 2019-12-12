using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class Shape3D : Shape2D
    {
        //ATTRIBUTE
        public double dbleVolume;

        //METHOD FOR DISPLAYING INFORMATION
        public void displayInfo3()
        {
            Console.WriteLine("The figure is: {0}", StrName);
            Console.WriteLine("The volume of the {0} is {1}", StrName,dbleVolume);
        }

        //INITIALIZE ATTRIBUTES
        public Shape3D()
        {
            StrName = "";
            dbleArea = 0;
            dblePerimeter = 0;
            dbleVolume = 0;
        }


    }
}
