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
<<<<<<< HEAD
            //added more changes........
=======
            //added more changes!!!!!!!!!!
>>>>>>> 0fefe2a744431ef4adc1c33d58f32bc956169302
            Calculation cal = new Calculation();
            //changes at different places
            int c = cal.AddNumber(5, 10);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
