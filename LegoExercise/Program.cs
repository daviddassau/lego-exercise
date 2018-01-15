using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoExercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class LegoBatman
    {
        public string Head;
        public string Body;
        public string Accessories;

        public LegoBatman(string batHelmet, string kevlarVest, string utilityBelt)
        {
            Head = batHelmet;
            Body = kevlarVest;
            Accessories = utilityBelt;
        }

        public string LegoBatmansSignatureAttack(bool handToHandCombat)
        {
            if (handToHandCombat == true)
                return "Lego Batman defeated you with his hand-to-hand combat skills";
            else
                return "Lego Batman used something from his utility belt to outsmart you";
        }
    }
}
