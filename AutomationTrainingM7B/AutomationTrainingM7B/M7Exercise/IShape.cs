using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    interface IShape 
    {
     //ATTRIBUTE
     string StrName { get; set; }

     //METHOD TO DISPLAY THE INFORMATION   
     void DisplayInfo();
    }
}
