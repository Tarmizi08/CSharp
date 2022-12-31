using System;

namespace Polymorphism
{
    class Animal//base class
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound.");
        }
    }

    class Cat:Animal // derived class
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: Meowwww");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dogs say: Wolfffff wolfff");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Animal();//create an animal object
            Animal cat = new Cat();// create a cat object
            Animal dog = new Dog();// create a dog object

            myPet.animalSound();
            cat.animalSound();
            dog.animalSound();
        }
    }
}

