using System;

namespace Exceptions
{
    class Program
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access is denied. You need to be at least 18 to go clubbing");
            }
            else
            {
                Console.WriteLine("Access granted");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int[] myNum = { 1, 2, 3 };
                Console.WriteLine(myNum[-1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try and catch' block has finished running");
            }

            CheckAge(19);
            
        }
    }
}

