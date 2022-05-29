using System;
namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car user = new Car();
            Car user1 = new Car();
            Console.ReadLine();
        }
    }
    public class Car
    {
        static Car()
        {
            Console.WriteLine("Static constructor called");
        }
        public Car()
        {
            Console.WriteLine("Default constructor called");
        }
    }
}
