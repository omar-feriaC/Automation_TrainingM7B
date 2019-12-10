﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.M7Exercise
{
    class _2D_Shape : IShape
    {
        public string strName { get; set; }
        public double dbleArea { get; set; }
        public double dblePerimeter { get; set; }
        public double dbleBase { get; set; }
        public double dbleHigh { get; set; }

        public _2D_Shape()
        {
            strName = "";
            dbleArea = 0;
            dblePerimeter = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
        }

    }
}
