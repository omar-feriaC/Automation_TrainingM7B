using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class Animals
    {
        private string test;
        public string type;
        public string environmentLiving;
        public string typeEat;

        public Animals()
        {
            test = "test";
            type = "No Type";
            environmentLiving = "No Enviroment";
            typeEat = "No Eat";
        }

        public Animals(string pTest, string pType, string pEnv, string pEat)
        {
            test = pTest;
            type = pType;
            environmentLiving = pEnv;
            typeEat = pEat;
        }


        public void fnEating()
        {
            Console.WriteLine("Master_Eating: " + typeEat);
        }

        public void fnSound()
        {
            Console.WriteLine("Master_Sound:");

        }

        public void fnMovement()
        {
            Console.WriteLine("Master_Movement:");

        }

    }
}
