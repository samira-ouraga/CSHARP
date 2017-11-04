using System;
using System.Collections.Generic;

namespace scope_csharp
{
    class Program
    {
// private and public are accessibility modifiers, allowing encaspulation
//private means that a method can b called by other method inside of class
// public method r what will be called by stuff outside of the code 
// a private field is like a property , but avaible to all elt  of class
private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for(int i=0; i<10; i++)
            {
                // i in only vail here , in this scope
                System.Console.WriteLine(i);
                j = i.ToString();
                k= i.ToString();

               
            }
            Console.WriteLine("outside of the for loop is j: " +j );
            Console.WriteLine("outside of the for loop is k:" +k );

             HelperMethod();

             Car myCar = new Car();
            // as I make an instance of the car, i can only access the 
            //public method in the constructor, but the public method will call on the private method to do his work 
             myCar.Dosomethign();

            Console.ReadLine();

        }

        // k was defined at class level, sibl to void main and help meth 
        // so accessible to them and their code
        static void HelperMethod()
        {
            System.Console.WriteLine("the value of k from helpmeth is " + k);
        }
//exp of private vs public 
        class Car{
            public void Dosomethign()
            {
                System.Console.WriteLine(HelperMethod());
            }

            private string HelperMethod()
            {
                return "hello word";
            }
        }
    }
}
