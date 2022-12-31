using System;
using System.Diagnostics.Metrics;

namespace CSharpLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            // for loops
            int number = 10;
            for (int counter = 1; counter < number; counter+=2)
            {
                Console.WriteLine(counter + " is odd number");
            }

            Console.WriteLine("For loop is done");
            Console.Read();
            */

            /*
            // do while loop
            // int counter = 0;
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please the name of a friend");
                string nameOfFriend= Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend;
                // Console.WriteLine(counter);
                // counter++;
            } while (lengthOfText < 20);

            Console.WriteLine("Thanks that was enough " + wholeText);
            */

            // while loop
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            /*
            int studentCounter = 0;
            string enteredTxt = "";
            while (enteredTxt.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else enter if you want to finish counting");
                enteredTxt = Console.ReadLine();
                studentCounter++;
                Console.WriteLine("Current people count is {0}", studentCounter);
            }

            Console.WriteLine("{0} are inside the bus. Press enter to exit the program.", studentCounter);
            */

            /*
            // break and continue

            for (int counter = 0; counter < 10; counter++)
            {
                //Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }

                Console.WriteLine(counter);
            }

            for (int counter = 0; counter < 10; counter++)
            {
                //Console.WriteLine(counter);
                if (counter % 2 == 0)
                {
                    Console.WriteLine("Now come an odd number");
                    continue;
                }

                Console.WriteLine(counter);
            }
            */
        }
    }
}

