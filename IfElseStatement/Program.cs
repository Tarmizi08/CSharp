using System;
using System.Threading.Channels;

namespace IfElseStatement
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            if (20 > 15)
            {
                Console.WriteLine("20 is greater than 15");
            }

            int x = 20;
            int y = 20;

            if(x > y)
            {
                Console.WriteLine("It true");
            }
            else
            {
                Console.WriteLine("Good Evening.");
            }

            string solution = x > y ? "It's true" : "Good Morning";
            Console.WriteLine(solution);

            int time = 15;
            if (time < 12)
            {
                Console.WriteLine("Good Morning");
            } else if (time < 18 && time > 12)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("GoodNight");
            }

            int temp = 30;
            int temp1 = 31;
            string cold = temp > temp1 ? "Wear your sweater" : "Wear your sunglasses";
            Console.WriteLine(cold);
            */
            /*
            //nested if
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");
                
                
                Console.WriteLine("Hi there, " + userName);
                    
                    
                Console.WriteLine("Hi there, Admin");

            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You're log in");
            }

            Console.Read();
            */


            //ternary operator

            // condition ? expressionTrue:expressionFalse;
            // condition has to be either true or false
            // the condition operator is right - associative.
            // the expression a? b: c? d:e;
            // is evaluated as a ? b:(c?d:e,
            // not as (a? b : c) ? d:e.
            // the conditional operator cannot be overloaded

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            temperature += 30;
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            temperature += 130;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of Matter is {0}", stateOfMatter);

        }
    }
}

