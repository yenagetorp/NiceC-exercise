using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box a = new Box(2.0, 3.5, 1.5);
            //Box b = new Box(2.0, 3.5, 1.5);
            //if (Box.LessThan(a, b))
            //{
            //    Console.WriteLine("a är mindre än b");
            //}

            //if (Box.GreaterThan(a,b))
            //{
            //    Console.WriteLine("a är större än b");
            //}

            ////operator overloading

            //if (a<b)
            //{
            //    Console.WriteLine("a är mindre än b");
            //}
            //if (a!=b)
            //{
            //    Console.WriteLine("two boxes are not the same !");
            //}

            //if (a.Equals(b))
            //{
            //    Console.WriteLine("Ture!!"); 
            //}

            Money m = new Money(2.5);
            Console.WriteLine(m.Balance);
            m++;
            Console.WriteLine(m.Balance);




        }
    }
}
