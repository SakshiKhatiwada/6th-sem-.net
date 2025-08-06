// See https://aka.ms/new-console-template for more information
using System;

namespace ClassConcept
{
    // class Car{
    //     string color="red"; //var declared in class => field or attribute

    //     static void Main(string[] args){
    //         Car BMW = new Car();
    //         Console.WriteLine(BMW.color);
    //     }
    // }

    // SECTION to make the code clean we write Main() on other class
    // class Car
    // {
    //     public string color = "red"; //public keyword is used
    //     int maxSpeed = 200;
    //     public int yearPurchased;
    //     public void FullThrottle()
    //     {
    //         Console.WriteLine("The car is going really fast with speed: " + maxSpeed);
    //     }

    //     public void PrintYear()
    //     {
    //         Console.WriteLine("The year purchased is: " + this.yearPurchased);
    //     }
    //     }

    // class Program{
    //     static void Main(string[] args)
    //     {
    //         // Car BMW = new Car();
    //         // Console.WriteLine(BMW.color);
    //         // BMW.FullThrottle();

    //         Car myCar = new Car();
    //         Car myCar2 = new Car();

    //         myCar.yearPurchased = 2014;
    //         myCar2.yearPurchased = 2016;

    //         myCar.PrintYear();
    //         myCar2.PrintYear();
    //     }
    // }

    //SECTION ---------------- 2082/04/21
    class Program{
        static void Main(string[] args){
           Book b1 = new Book();
           Book b2 = new Book();

           b1.setAuthor("James");
           b1.setPrice("200");
           b1.setTitle("Atomic Habits");

           b2.setAuthor("Jimmy");
           b2.setPrice("300");
           b2.setTitle("The Stone");

           b1.printBook();
           b2.printBook();

           Dog d1 = new Dog();
           d1.eat();
           d1.bark();
        }
    } 

    class Book{
        private string title;
        private string price;
        private string author;

        public void setTitle(string tit){
            title = tit;
        }
        public void setPrice(string p){
            price = p;
        }
        public void setAuthor(string auth){
            author = auth;
        }

        public void printBook()
        {
            Console.WriteLine(title);
            Console.WriteLine(price);
            Console.WriteLine(author);
        }
    }

    class Dog{

        public Dog(){ 
            //constructor
        Console.WriteLine("A Dog:");
        }


        public void eat(){
            Console.WriteLine("Dog eats meat");
        }

        public void bark(){
            Console.WriteLine("A dog goes woof. It barks!");
        }
    }

}
