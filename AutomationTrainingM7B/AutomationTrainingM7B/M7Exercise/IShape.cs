using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    interface IShape
    {
        double area { get; set; }
        double perimeter { get; set; }
        string name { get; set; }

        void DisplayInfo();
    }
}
