using System;

namespace Interfaces
{
    //interfaces does not have a field member
    interface IAnimal
    {
        void animalSound();//interface method does not have a body
        void run();//interface method
    }
    //pig class implements the IAnimal interfaces
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says wee wee");
        }

        public void run()
        {
            Console.WriteLine("Pig is running");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Pig pink = new Pig();
            pink.animalSound();
            pink.run();
        }
    }
}

