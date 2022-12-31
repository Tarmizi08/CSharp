using System;

namespace AccessModifier
{
    class Car
    {
        //private string model = "Vios";//encapsulation
        public string model = "Vios";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.model);
        }
    }
}

