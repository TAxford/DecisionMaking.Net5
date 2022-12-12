using System;

namespace DecisionMaking.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature outside?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            
            if (numTemp < 10)
            {
                Console.WriteLine("take the coat");
            }else if(numTemp == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }else
            {
                Console.WriteLine("Cozy & warm!");
            }

            Console.Read();
        }
    }
}
