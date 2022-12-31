using System;

namespace OOPConstructor
{
    class Program
    {
        //class
        class Car
        {
            public string model;//field
            public string color;
            public int year;

            // this is a constructor for the car class
            public Car(string modelName, string color, int year)
            {
                model = modelName; // sets the initial value for model
                this.color = color;
                this.year = year;
            }
        }
        static void Main(string[] args)
        {
            Car Toyota = new Car("Camry","red",2021); // create an object of the car class
            Console.WriteLine(Toyota.model + " " + Toyota.color + " " + Toyota.year);

        }
    }
}

