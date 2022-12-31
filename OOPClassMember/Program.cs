using System;

namespace OOPClassMember
{
    //the class
    class Car
    {
        // class members
        public string color; //field
        public int maxSpeed;//field
        public int year; // field
        public string model;//field

        // class method
        public void Drive()
        {
            Console.WriteLine("Your car is driving.....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Car myObj = new Car();
            //myObj.color = "red";
            //myObj.maxSpeed = 300;
            //Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj.maxSpeed);
            Car Toyota = new Car();
            Toyota.model = "Vios";
            Toyota.color = "red mica";
            Toyota.maxSpeed = 240;
            Toyota.year = 2021;

            Car Perodua = new Car();
            Perodua.model = "Bezza";
            Perodua.maxSpeed = 200;
            Perodua.color = "Ocean Blue";
            Perodua.year = 2018;

            Console.WriteLine(Toyota.model);
            Console.WriteLine(Perodua.model);
            Perodua.Drive();//call the drive method of the Car class
        }
    }
}

