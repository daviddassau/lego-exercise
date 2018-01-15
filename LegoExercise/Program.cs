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

    class LegoWyldstyle
    {
        protected string _head;
        public string Head
        { get { return _head; } set { _head = value; } }

        protected string _body;
        public string Body
        { get { return _body; } set { _body = value; } }

        protected string _accessories;
        public string Accessories
        { get { return _accessories; } set { _accessories = value; } }

        public string WyldstyleIsAMasterBuilder(bool isAMasterBuilder)
        {
            if (isAMasterBuilder == true)
                return "Wyldstyle is an amazing master builder";
            else
                return "Wyldstyle appears to have run out of things to build";
        }
    }
}
