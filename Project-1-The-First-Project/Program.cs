﻿// See https://aka.ms/new-console-template for more information
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
            // string name = "Ram Bahadur";
            // int age = 22;
            // C# variables with concatenation example.
            // Console.WriteLine("Hello everyone! My name is "+name+" and my age is "+age);

            // Console.WriteLine("Enter Your Name: ");
            // name = Console.ReadLine();
            // Console.WriteLine("Enter your age: ");
            // age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Hello everyone! My name is "+name+" and my age is "+age);

            // SECTION Day 3
            // ---------------------------- Arithmetic Operators
            // int x,y, addition, subtraction, multiply, division;
            // Console.WriteLine("Enter first number: ");
            // x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter second number: ");
            // y = Convert.ToInt32(Console.ReadLine());

            // addition = x + y;
            // subtraction = x - y;
            // multiply = x * y;
            // division = x/y;

            // Console.WriteLine("The numbers you entered are: " + x + ", " + y);
            // Console.WriteLine("After addition: " + addition);
            // Console.WriteLine("After subtraction: " + subtraction);
            // Console.WriteLine("After multiplication: " + multiply);
            // Console.WriteLine("After division: " + division);

            // ------------------------------ To check if given number is even or odd
            // int num1;
            // Console.WriteLine("Enter the number to check whether it's odd or even: ");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // if (num1%2 == 0)
            // Console.WriteLine("The given number " + num1 + " is even.");
            // else
            // Console.WriteLine("The given number "+ num1 + " is odd.");

            // -------------------------------- To print * pattern
            // int nlines;
            // Console.WriteLine("Enter the number of lines you want to print: ");
            // nlines = Convert.ToInt32(Console.ReadLine());

            // for (int i=1; i<=nlines; i++){
            //     for(int j = i; j<=(nlines); j++){
            //         Console.Write(" ");
            //     }
            //     for (int k = 1; k<=2*i-1; k=k+1){
            //     Console.Write("*");
            //     }
            //     Console.Write("\n");
            // }

            //SECTION - Day 4
            // To print odd or even numbers based on user's input
            string choice;
            int upto;
            Console.WriteLine("Enter whether you want to print odd numbers or even numbers ?");
            choice = Console.ReadLine();
            if (!String.Equals(choice.ToLower(), "odd") && !String.Equals(choice.ToLower(),"even")){
                Console.WriteLine("Please Choose either 'odd' or 'even': ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Upto what number ?");
            upto = Convert.ToInt32(Console.ReadLine());

            void printing(int start, int end) {
                for (int i = start; i<end; i = i+2)
                {
                    Console.Write(i+" ");
                }
            }

            Console.WriteLine(choice + " numbers upto "+ upto + " are: ");

            if (String.Equals(choice.ToLower(), "odd"))
            {
                printing(1,upto);
            }

            else if (String.Equals(choice.ToLower(), "even"))
            {
                printing(0,upto);
            }
            else {
                Console.WriteLine("You still gave wrong input. Please try again later!");
            }

        }
    }
}
