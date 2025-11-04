using System;

namespace DemoProject{
    // class TestOperator{
    //     static void Main(string[] args){
    //         // Console.WriteLine("hi");
    //         string a = "hello";
    //         string b = "sakshi";
    //         Console.WriteLine(a+b);
    //         // Console.WriteLine(a-b); # Error
    //     }
    // }

    interface Interface1{
        void Test();
    }
    interface Interface2
    {
        void Test();
    }
    
    class TestClass : Interface1, Interface2
    {
        void Interface1.Test()
        {
            Console.WriteLine("test implemented for 1");
        }
        void Interface2.Test()
        {
            Console.WriteLine("test implemented for 2");
        }

        public static void Main()
        {
            TestClass obj = new TestClass();
            // obj.Interface1.Test(); # error
            // obj.Test(); # error

            // # use the reference of the interface
            Interface1 i1 = obj;
            Interface2 i2 = obj;

            i1.Test();
            i2.Test();
        }
    }
}