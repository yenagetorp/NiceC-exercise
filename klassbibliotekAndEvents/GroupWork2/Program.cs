using System;
using NumberUtils;
namespace GroupWork2
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        ///  //Events:
        //A mechanism for communication between objects
        //Used in building Loosely Coupled Applications
        //Helps extending applications
        /// </summary>
        static void Main(string[] args)
        {
            var NumberGenerator = new NumberGenerator();//publisher //Att exponera ett event

            NumberGenerator.Even += NumberGenerator_Even; //att prenumerera på ett event.
            //the name of the delegate
            //NumberGenerator_Even does not matter, but the signature of the method
            //should be the same as the delegate's name.
            NumberGenerator.Start();
        }

        

        /// <summary>
        /// Lyssnar-method(event-handler).
        /// Delegates: agreement/contract between publisher and subscriber(user).
        /// determines the signature of the event handler method in subscriber.
        /// </summary>
        /// <param name="i"></param>
        private static void NumberGenerator_Even(int i)
        {
            if( i %2 == 0)
            Console.WriteLine($"{i}  Jämt tal!");
            else
            Console.WriteLine($"{i}  Udda tal!");
        }
    }
}
