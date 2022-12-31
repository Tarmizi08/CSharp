using System;
using System.Xml;

namespace Abstraction
{
    //Abstract method 
    abstract class Animal
    {
        public abstract void animalSound();
        //regular method
        public void sleep()
        {
            Console.WriteLine("zzzz");
        }
    }

    class Pig : Animal //derived class(inherited from animal class
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig say wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();// create a pig object
            pig.animalSound();// call the abstract method
            pig.sleep();// call the regular method
        }
    }
}

