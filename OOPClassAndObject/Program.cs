using System;

namespace OOPClassAndObject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car myObj = new Car();// instance of class Car
            Console.WriteLine(myObj.color);

            Car myCar = new Car();
            Console.WriteLine(myCar.carName);
        }
    }

    class Car
    {
        public string color = "red";
        public string carName = "Toyota Vios";
    }
}

