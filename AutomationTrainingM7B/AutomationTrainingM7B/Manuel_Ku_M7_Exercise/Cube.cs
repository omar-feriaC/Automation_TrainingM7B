using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Manuel_Ku_M7_Exercise
{
    public class Cube : _3D_Shape
    {
        public new double Base { get; set; }
        public double Altura { get; set; }

        public Cube()//Inicialization
        {
            Base = 0;
            Altura = 0;
            Area = 0;
            Perimeter = 0;
            Name = "Cube";
        }
        public Cube(double bC)
        {
            Base = bC;
        }
        public double GetCubeAreaTotal()//if Base=S : Area = 6 * S^2 cm2
        {
            double Area;           
            Math.Pow(Base, 2);
            return Area = Base*6;           
        }
        public double GetCubePerimeter()// Perimeter = 12 * S  cm
        {
            double Perimeter;
            return Perimeter = Base * 6 ;
        }
        public double GetCubeVolume()//Equilateral triangle Volume = S^3 cm3
        {
            double Volume;
            Math.Pow(Base, 3);
            return Volume=Base;
        }
        
    }
}
