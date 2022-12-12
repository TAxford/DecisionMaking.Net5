using System;

namespace DecisionMaking.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 10;

            if (temperature < 10)
            {
                Console.WriteLine("take the coat");
            }

            if(temperature == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }

            if(temperature > 10)
            {
                Console.WriteLine("Cozy & warm!");
            }

            Console.Read();
        }
    }
}
