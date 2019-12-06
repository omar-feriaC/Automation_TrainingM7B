using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class CalculateSalary : InterfaceEmployee
    {
        public string strID { get; set; }
        public string strName { get; set ; }
        public string strLastName { get; set; }
        public string strSalary { get; set; }

        public void fnPrintData()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
