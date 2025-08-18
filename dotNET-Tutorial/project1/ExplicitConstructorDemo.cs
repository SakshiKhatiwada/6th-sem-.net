using System;
namespace ConstructorDemo;

class ExplicitConstructorDemo{
// <modifier> <class_name>(<parameter_list>)
public ExplicitConstructorDemo(){
    Console.WriteLine("Constructor is called here!");
}

static void Main(){
    ExplicitConstructorDemo obj = new ExplicitConstructorDemo();
}
}