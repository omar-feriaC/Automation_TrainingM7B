using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingM7B.Page_Objects
{
    class Dog : Animals
    {
        public string raza;
        public string dogSound;

        public Dog()
        {
            dogSound = "ladrar";
            raza = "poodle";
            environmentLiving = "Casa";
        }

        public Dog(string pstrRaza, string pstrLadrar)
        {
            dogSound = pstrLadrar;
            raza = pstrRaza;
        }

        public void fnSound()
        {
            Console.WriteLine("Dog: " + dogSound);
            Console.WriteLine("Living: " + environmentLiving);
        }

        public void fnPrintRaza()
        {
            Console.WriteLine("Raza: " + raza);
        }
    }
}
