using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Full Sail!");

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            string age = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "! Congratulations on living to the age of " + age + "!");

            Console.ReadKey();
        }
    }
}
