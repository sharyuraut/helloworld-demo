//using HelloWorld.services;
using HelloWorld.services;
using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            int c = cal.AddNumber(5, 10);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
