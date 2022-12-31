using System;

namespace String
{
    class Program
    {
        public static void Main(string[] args)
        {
            string greeting = "Hello";
            //string method
            // string.length
            // toupper() || tolower()
            // string.Concat() to concat string

            string firstName = "Tarmizi";
            string lastName = "Ismail";
            string name1 = string.Concat(firstName, lastName);
            string name = $"My full name is: {firstName}{lastName}";
            string myString = "Hope";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("H"));

            // Substring()
            string fullName = "Tarmizi Ismail";
            int charPos = fullName.IndexOf("i");

            string lastName2 = fullName.Substring(charPos + 1);
            Console.WriteLine(lastName2);
            string txt = "You're the real \"MVP\" for getting this far";
        }
    }
}

