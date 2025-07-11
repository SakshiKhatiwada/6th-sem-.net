// See https://aka.ms/new-console-template for more information
using System;

namespace Project1
{

       class Program
    {
        static void Main(string[] args)
        {
            // SECTION Day 1
            // Console.WriteLine("Hello, Sakshi!");
            // var x = Console.ReadLine();
            // Console.WriteLine("hi " + x);
            // Console.WriteLine(Console.ReadKey());
            // ConsoleKeyInfo clickedKey = Console.ReadKey();
            // Console.Write("\n");
            // Console.WriteLine(clickedKey.Key);
            // Console.WriteLine(clickedKey.KeyChar);
            // Console.WriteLine(clickedKey.Modifiers);

            // SECTION Day 2
            // C# Variables example
            string name = "Ram Bahadur";
            int age = 22;
            // C# variables with concatenation example.
            Console.WriteLine("Hello everyone! My name is "+name+" and my age is "+age);

            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello everyone! My name is "+name+" and my age is "+age);

        }
    }
}
