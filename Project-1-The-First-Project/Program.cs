// See https://aka.ms/new-console-template for more information
using System;

namespace Project1
{

       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Sakshi!");
            // var x = Console.ReadLine();
            // Console.WriteLine("hi " + x);
            // Console.WriteLine(Console.ReadKey());
            ConsoleKeyInfo clickedKey = Console.ReadKey();
            Console.Write("\n");
            Console.WriteLine(clickedKey.Key);
            Console.WriteLine(clickedKey.KeyChar);
            Console.WriteLine(clickedKey.Modifiers);
        }
    }
}
