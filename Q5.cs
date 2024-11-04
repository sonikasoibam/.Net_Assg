using System;

namespace ConstructorExample
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default Constructor called.");
        }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized Constructor called.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Person person1 = new Person();
            person1.DisplayInfo();

            // Using parameterized constructor
            Person person2 = new Person("Alice", 30);
            person2.DisplayInfo();
        }
    }
}
