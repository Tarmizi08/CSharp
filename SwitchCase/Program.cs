using System;

namespace SwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int age = 25;
            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            int numAge;
            int numb;
            if (int.TryParse(age, out numb))
            {
                numAge = numb;
            }
            else
            {
                numAge = 15;
                Console.WriteLine("Please enter the correct age number!");
            }

            switch (numAge)
            {
                case 15:
                    Console.WriteLine("Too young to party");
                    break;
                case 25:
                    Console.WriteLine("Good to go");
                    break;
                default:
                    Console.WriteLine("Let's Party, How old are you then!");
                    break;
            }

            if (numAge == 15)
            {
                Console.WriteLine("Too young to party");
            } else if (numAge == 25)
            {
                Console.WriteLine("Good to go");
            }
            else
            {
                Console.WriteLine("Let's Party");
            }
            Console.Read();
        }
    }
}

