﻿//using HelloWorld.services;
using HelloWorld.services;
using System;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //changes
            Calculation cal = new Calculation();
            int c = cal.AddNumber(5, 10);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
