using System;

namespace CSArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] grades = new int[5];

            grades[0] = 12;
            grades[1] = 23;
            grades[2] = 24;
            grades[3] = 25;
            grades[4] = 26;

            Console.WriteLine("grades at 0 {0}", grades[0]);

            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("New array at pos 0 is {0}.", grades[0]);
            */


            /*
            int[] gradesOfMathClassA = { 20, 14, 52, 45, 66 };
            int[] gradesOfMathClassB = { 25, 52, 44, 56, 14 };

            Console.WriteLine("Length of gradesOfMathClassA is {0}", gradesOfMathClassA.Length);
            Console.WriteLine("Length of gradesOfMathClassB is {0}", gradesOfMathClassB.Length);

            foreach (var grades in gradesOfMathClassA)Saft advisory
            {
                Console.WriteLine(grades);
            }
            */

            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            // k has the same type as the value in nums
            // slower than the for loops
            int counter = 0;
            foreach (var k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k);
                counter++;
            }
            Console.ReadKey();


            string[] myFriends = { "Michel", "Bob", "Lia", "Saphy" };

            foreach (var friend in myFriends)
            {
                Console.WriteLine("Hello, good Morning {0}", friend);
            }
            Console.ReadKey();

        }
    }
}

