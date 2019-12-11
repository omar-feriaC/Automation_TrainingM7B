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
    
}
