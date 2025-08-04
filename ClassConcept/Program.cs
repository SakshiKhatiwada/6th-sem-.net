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

    // SECTION to make the code clean
    class Car
    {
        public string color = "red"; //public keyword is used
        int maxSpeed = 200;
        public int yearPurchased;
        public void FullThrottle()
        {
            Console.WriteLine("The car is going really fast with speed: " + maxSpeed);
        }

        public void PrintYear()
        {
            Console.WriteLine("The year purchased is: " + this.yearPurchased);
        }
        }

    class Program(){
        static void Main(string[] args)
        {
            // Car BMW = new Car();
            // Console.WriteLine(BMW.color);
            // BMW.FullThrottle();

            Car myCar = new Car();
            Car myCar2 = new Car();

            myCar.yearPurchased = 2014;
            myCar2.yearPurchased = 2016;

            myCar.PrintYear();
            myCar2.PrintYear();
        }
    }
}
