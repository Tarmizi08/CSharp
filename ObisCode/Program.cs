using System;
using System.Transactions;

namespace ObisCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // type variableName = value;
            string name = "Tarmizi";
            int num1 = 12;
            bool isTrue = true;
            double num2 = 12.5;
            char ch = 'c';

            string lastName; // declare the variable w/o value
            lastName = "Ismail"; // value was assigned later

            name = "Mohammad";
            string firstName = name;

            // concatenation
            string fullname = firstName + ' ' + lastName;
            Console.WriteLine("My name is " + fullname);

            const double PI = 3.14159;// cannot change const value

            double result = num1 + num2;
            double subresults = num1 - num2;
            double mulresults = num1 * num2;
            double divresults = num1 / num2;
            double remresults = num1 % num2;
            Console.WriteLine(result);
            Console.WriteLine(subresults);
            Console.WriteLine(mulresults);
            Console.WriteLine(divresults);
            Console.WriteLine(remresults);

            int a, b, c;
            a = b = c = 10;
            Console.WriteLine(a + b + c);

            int minimumInt = int.MinValue;
            int maximumInt = int.MaxValue;
            Console.WriteLine(minimumInt);
            Console.WriteLine(maximumInt);
            Console.WriteLine($"The minimum value is {minimumInt} and the maximum value is {maximumInt}");
            

            long secondsMakeTenYears = 31560000000L;
            long longMin = long.MinValue;
            long longMax = long.MaxValue;

            Console.WriteLine($"The minimum value for long data type is {longMin}, while the max value for long is {longMax}.");
            

            //float datatype
            float minimumInt = float.MinValue;
            float maximumInt = float.MaxValue;
            Console.WriteLine($"Min of float number is {minimumInt} and the max of float number is {maximumInt}");
            double minimumInt1 = double.MinValue;
            double maximumInt1 = double.MaxValue;
            Console.WriteLine($"Min of float number is {minimumInt1} and the max of float number is {maximumInt1}");

        
            // scientific notation
            //e or E
            double d = 0.12e2;//0.12 x 10^2 =12
            Console.WriteLine(d);

            //default number for all number type is 0
            int i = default;// output 0
            float f = default;// 0

            //booleans
            bool isDataTypeUseful = false;
            bool isProgrammingNotEasy=false;// output false
            //default value is false.
            bool isBool = default;
            

            // characters : char
            char passGrade = 'A';
            // the default value is '\0'
            char dF = default;//'\0'

            //string
            string greeting = "Hello Tarmizi";
            Console.WriteLine(greeting);
            

            // type casting
            int myInt = 25;
            double myDouble = myInt;//autimatic or implicit casting
            Console.WriteLine("myInt value is {0} and myDouble value is {1}", myInt, myDouble);

            double myDouble2 = 5.34;
            int myInt2 = (int)myDouble2;// the explicit manual conversion the datatype need to be put inside the ().
            Console.WriteLine("the mydouble2 value {0} and the myInt2 value {1}", myDouble2, myInt2);
            

            // char -> int -> long -> float -> double

            // double -> float -> long -> int -> char
            // convert.ToBoolean
            //Convert.ToDouble
            //Convert.ToString
            //Convert.ToInt32 (int) or ToInt64 (long)
            //Convert.ToFloat

            string myString = "true";
            char myChar = 'a';
            double myDouble = 3.5;
            
            Console.WriteLine(Convert.ToInt32(myDouble));// 4
            Console.WriteLine(Convert.ToString(myChar));// a
            Console.WriteLine(Convert.ToBoolean(myString));// True
            

            //get user input
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();// return a string value
            Console.WriteLine("Your name is {0}", name);

            Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My age is {0}", age);
            // also can use Int.Parse but it will return an error if user input the wrong datatype value
            // use TryParse for safety.
            */
            //Console.WriteLine(Calculator());
            /*
            Console.WriteLine("Enter the correct number:");
            string numInput = Console.ReadLine();
            try
            {
                int userInputInt = int.Parse(numInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the correct input");
            }
            catch(OverflowException)
            {
                Console.WriteLine("General Exception");
            }
            finally
            {
                Console.WriteLine("This called anyway");
            }
            */



            /*
            //operator
            int x = 2 + 3;
            Console.WriteLine(x);

            int y = 45;
            Console.WriteLine(y + x);
            */




        }
        /*
        public static int Calculator()
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            string number2 = Console.ReadLine();

            int numb1 =int.Parse(number1);
            int numb2 =int.Parse(number2);

            int result = numb1 + numb2;
            return result;
        }
        */
    }
}

