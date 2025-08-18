using System;
namespace ConstructorDemo;

class Program {
        int i;
        bool b;
        string s;
    static void main(string[] args){
        Program obj = new Program();
        Console.WriteLine("Value of i: " + obj.i);
        Console.WriteLine("Value of b: " + obj.b);
        Console.WriteLine("Value of s: " + obj.s);
    }
}