using System;

namespace GetAndSet
{

    class Person
    {
        private string name;//field


        //property combination of a field and method
        public string Name
        {
            get { return name; }//get method
            set { name = value; }// set method assign the value to name variable
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Tarmizi";
            Console.WriteLine(person.Name);
        }
    }
}

