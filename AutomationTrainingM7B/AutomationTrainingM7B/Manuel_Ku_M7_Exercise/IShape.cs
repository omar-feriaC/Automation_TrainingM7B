using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTrainingM7B.Manuel_Ku_M7_Exercise;


namespace AutomationTrainingM7B.Manuel_Ku_M7_Exercise
{
    public interface IShape 
    {
        double Area { get; set; }
        double Perimeter { get; set; }
       
        void DisplayInfo();
    }

    //public class _2D_Shape :  IShape
    //{
    //    double Area;
    //    double Perimeter;
    //    public _2D_Shape()
    //    {
    //        Area = 0;
    //        Perimeter = 0;
    //        Name = "Undefined";
            
    //        Console.WriteLine("Derived class 2D_Shape : {0} : {1}", Area, Perimeter);
    //    }
    //}

}
