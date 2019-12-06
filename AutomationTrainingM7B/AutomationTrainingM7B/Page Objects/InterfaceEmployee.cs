using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    interface InterfaceEmployee
    {
        string strID { get; set; }
        string strName { get; set; }
        string strLastName { get; set; }
        string strSalary { get; set; }
        void fnPrintData();
    }
}
