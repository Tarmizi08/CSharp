using System;

namespace TryParse
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature today? ");
            //int temperature = Convert.ToInt32(Console.ReadLine());
            string temp = Console.ReadLine();
            //int numTemp = int.Parse(temp);// this will return an integer, but if the value not an integer the program will crash

            int numTemp;
            int number;
            if (int.TryParse(temp, out number))// we parse the string temp to an int then pass it to the number variable
            {
                numTemp = number;// this will check if user entered the number True
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered is not a number so temp set to 0");
            }

            if (numTemp <= 10)
            {
                Console.WriteLine("Wear the coat");
            } else if (numTemp < 20 && numTemp > 10)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }else if (numTemp >= 20 && numTemp <= 30)
            {
                Console.WriteLine("Shorts are enough today");
            }
            else
            {
                Console.WriteLine("GoodDay!");
            }



        }
    }
}

