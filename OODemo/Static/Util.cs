using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Util  //obs: static calss,no instanses, cant use as base class,  then all the class medlemmar vara static. 
    {
        public const string CompanyName = "ACADEMY";
        public static void SaveTheWord()
        {
            Console.WriteLine("Hejeje");
        }

        public static void DestroyTheWorld()
        {
            SaveTheWord();
        }
    }
}
