namespace InterfaceSegregation
{
    // Interface for flying animals.
    public interface IFlyable
    {
        void Fly();
    }

    // Interface for swimming animals.
    public interface ISwimmable
    {
        void Swim();
    }

    // A class that only needs to fly.
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying!");
        }
    }

    // A class that only needs to swim.
    public class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("Swimming!");
        }
    }
}

// A class should not be forced to implement methods it doesn't need.
// In other words, a class should have small, focused interfaces rather than large, monolithic ones.

// Many small tools are better than one big tool.
// Don’t force a class to use methods it doesn’t need.