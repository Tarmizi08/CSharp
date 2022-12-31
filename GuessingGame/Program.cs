using System;

namespace GuessingGame
{
    class Program
    {
         static int guess;
         static int target;
         static Random randomNumber = new Random();
         private static string input = "";

        static void Game()
        {
            // generate random number
            target = randomNumber.Next(10) + 1;
            
            //statements that runs the game
            // prompt the user
            Console.WriteLine("Guess what number between 1 to 10 I am thinking of...\n");

            // read user input
            input = Console.ReadLine();

            //feedback
            if (int.TryParse(input, out guess))
            {
                if (guess == target)
                {
                    Console.WriteLine("Congratulation!, You Guessed it Right " + guess);
                }
                else
                {
                    Console.WriteLine("Try AGAIN. You guessed {0}, the number I was thinking of {1}\n", guess, target);
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to continue....\n");
                Console.ReadLine();
                Game();
            }
            
            //Console.WriteLine("You guess " + guess + " and the number I was thinking of was " + target);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Game();
            }
        }
    }
}

