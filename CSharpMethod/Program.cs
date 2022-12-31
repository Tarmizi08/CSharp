using System;

namespace CSharpMethod
{
    class Program
    {
        static void MyMethod(string name = "Ismail")
        {
            // code to be executed
            // method need to named capital letter
            Console.WriteLine("Hello, {0}, welcome to CSharp Tutorial.", name);
        }

        static void MySecondMethod(string name, int age)
        {
            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }

        static int MyThirdMethod(int x, int y)
        {
            return 10 + x * y;
        }

        static void My4Method(string player1, string player2,string player3)
        {
            Console.WriteLine("The fastest player is: " + player3);
        }

        public static void Main(string[] args)
        {
            MyMethod("Tarmizi");
            MyMethod("Fairuh");
            MyMethod("Suhada");
            Console.WriteLine("later come the default parameter value, called optional parameter.");
            MyMethod();

            MySecondMethod("Tarmizi", 29);

            Console.WriteLine(MyThirdMethod(2,2));
            // parameter and arguments

            // named arguments key:value
            My4Method(player3:"Joseph", player1:"adam",player2:"mamat");

            // method overloading
        }
    }
}

