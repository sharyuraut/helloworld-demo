//using HelloWorld.services;
using HelloWorld.services;
using System;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //changes
            //added more changes
            Calculation cal = new Calculation();
            //changes at different places
            int c = cal.AddNumber(5, 10);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
