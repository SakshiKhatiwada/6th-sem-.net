// See https://aka.ms/new-console-template for more information
using System;
namespace Teacher
{

class Teacher{
// Field = Class-level variable that holds the value
private int id;

// Property = encapsulate a private field to assign underlying field value
public int TeacherId{
    get{return id;}
    set{
        if(value>0)
        id = value;}
}

public Teacher(){
    Console.WriteLine("This is constructor");
}
static void Main(string[] args)
{
    // Objects of the class

Teacher T1 = new Teacher();
T1.TeacherId = 1;
Console.WriteLine(T1.TeacherId);
}


}
}