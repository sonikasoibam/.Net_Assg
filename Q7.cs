using System;

namespace InterfaceExample
{
    // Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // Define the IFlyable interface
    public interface IFlyable
    {
        void Fly();
    }

    // Bird class implements both IMovable and IFlyable interfaces
    public class Bird : IMovable, IFlyable
    {
        public void Move()
        {
            Console.WriteLine("The bird is moving on the ground.");
        }

        public void Fly()
        {
            Console.WriteLine("The bird is flying in the sky.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird();
            myBird.Move(); // Calls the Move method from IMovable
            myBird.Fly();  // Calls the Fly method from IFlyable

            Console.ReadLine();
        }
    }
}
