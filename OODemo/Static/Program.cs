using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{



    internal  class Program
    {
        private static void Main(string[] args)
        {
            //Util.SaveTheWord();
            //Console.WriteLine(Util.CompanyName ); 
            // Util u = new Util();
            Random r = new Random(1962);

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(r.Next(1, 10+1));
            }
        }
    }
}
