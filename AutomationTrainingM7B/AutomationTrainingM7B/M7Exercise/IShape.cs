﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    interface IShape
    {
        /*ATTRIBUTES*/
        double dbleArea { get; set; }
        double dblePerimeter { get; set; }
        string strName { get; set; }

        void DisplayInfo();
    }
}
