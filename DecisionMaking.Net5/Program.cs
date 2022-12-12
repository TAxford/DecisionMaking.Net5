using System;

namespace DecisionMaking.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            Console.WriteLine("What is the temperature outside?");
            Console.ReadLine();


            if (numTemp < 10)
            {
                Console.WriteLine("take the coat");
            }

            if(numTemp == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }

            if(numTemp > 10)
            {
                Console.WriteLine("Cozy & warm!");
            }

            Console.Read();
        }
    }
}
