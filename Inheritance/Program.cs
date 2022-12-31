using System;

namespace Inheritance
{
    // used sealed to avoid inheritance
    class Vehicle // parent class or base class
    {
        public string brand = "Vios";//vehicle field

        public void Start()// vehicle method
        {
            Console.WriteLine("Engine starting...");
        }
    }

    class Car : Vehicle // the child class or derived class
    {
        public string modelName = "GRS";
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create myCar object
            Car myCar = new Car();


            //calll the start() method from the vehicle class on mycar object
            myCar.Start();
            Console.WriteLine(myCar.brand);
        }
    }
}

