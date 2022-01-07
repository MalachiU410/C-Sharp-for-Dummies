using System;
namespace Program1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
