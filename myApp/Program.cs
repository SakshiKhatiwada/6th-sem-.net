using System;

namespace myApp{
    class Program{
        static void Main(){
            // Dog dog = new Dog();
            // dog.eat();
            // dog.walk();
            // dog.bark();

            User user = new User();
            user.getUserInfo();
            user.showUserInfo();
        }
    }

    // Single Level Inheritance
    // public class Animal{
    //     public void eat(){
    //         Console.WriteLine("Eating...");
    //     }
    // }
    // public class Mammal : Animal{ // Dog inherits from Animal
    //     public void walk(){
    //         Console.WriteLine("Walking...");
    //     }     
    // }

    // // Multi Level Inheritance 
    // public class Dog : Mammal{ 
    //     public void bark(){
    //         Console.WriteLine("Barking...");
    //     }     
    // }

    class User{
        string name;
        int age;
        string phoneNumber;
        string address;
        string email;

        public void getUserInfo(){
            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number: ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            email = Console.ReadLine();
        }

        public void showUserInfo(){
            Console.WriteLine("---------------Details--------------\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone number: " + phoneNumber );
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
        }
    }

}