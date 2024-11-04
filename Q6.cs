using System;

namespace InheritanceExample
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    // Single inheritance: Dog inherits from Animal
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }

    // Multi-level inheritance: Bulldog inherits from Dog
    class Bulldog : Dog
    {
        public void ShowBreed()
        {
            Console.WriteLine("This is a Bulldog.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            Dog myDog = new Dog();
            myDog.Eat(); // From Animal class
            myDog.Bark(); // From Dog class

            // Multi-Level Inheritance
            Bulldog myBulldog = new Bulldog();
            myBulldog.Eat(); // From Animal class
            myBulldog.Bark(); // From Dog class
            myBulldog.ShowBreed(); // From Bulldog class

            Console.ReadLine();
        }
    }
}
