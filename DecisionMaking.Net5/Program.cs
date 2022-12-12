using System;

namespace DecisionMaking.Net5
{
    internal class Program
    {
               
        static void Main(string[] args)
        {
            //is else if statement
            /*Console.WriteLine("What is the temperature outside?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp=0;
                Console.WriteLine("Value entered, was no number. 0 was set as temperature.");
            }

            
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


            //tryParse
            /*string numberAsString = "128";
            int parsedValue;
            bool success =int.TryParse(numberAsString, out parsedValue);

            if (success)
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            else
                Console.WriteLine("Parsing failed");*/

            //Nested If Statment
            bool isAdmin = false ;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your user name");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
                Console.Read()
;            }





        }
    }
}
