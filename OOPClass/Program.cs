using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace OOPClass
{
    class Human
    {
        // field members
        public string name;
        public int age;
        private string motherName;
        private string address;

        public string MotherName
        {
            get
            {
                return motherName;
            }
            set
            {
                motherName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address= value;
            }
        }

        public Human(string name, int age, string motherName, string address)
        {
            this.name = name;
            this.age = age;
            this.motherName = motherName;
            this.address = address;
        }

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Human(string name,string address)
        {
            this.name = name;
            this.address = address;
        }

        // this is a method
        public void SayHello()
        {
            Console.WriteLine($"Hi, I am {name}, I am {age} years old.");
        }

        public void MyIntro()
        {
            if (name != null && age != null && motherName != null && address != null)
            {
                Console.WriteLine($"Hi, my name is {name}, I live in {Address}. I am second son of {MotherName}, I am {age} years old.");
            } 
            else if (name != null && age != 0)
            {
                Console.WriteLine($"Hi, my name is {name}, I am {age} years old.");
            } 
            else if (name != null && address != null)  

            {
                Console.WriteLine($"Hi, my name is {name}.I live in {Address}");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human newHuman = new Human("Tarmizi",28, "Patimah", "Sungai Petani");
            Human newHuman2 = new Human("Tarmizi", 28);
            Human newHuman3 = new Human("Tarmizi", "Sungai Petani");
            //newHuman.name = "Tarmizi";
            //newHuman.age = 29;
            //newHuman.SayHello();
            //newHuman.MotherName = "Patimah";
            //newHuman.Address = "Sungai Petani";
            newHuman.MyIntro();
            newHuman2.MyIntro();
            newHuman3.MyIntro();
            


        }
    }
}

