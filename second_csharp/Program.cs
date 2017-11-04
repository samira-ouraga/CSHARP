using System;
using System.Collections.Generic;

namespace second_csharp
{
    public class Program
    {
        public static string SayHello(string name="samira")
        {
            return $"hey, {name}";
        }

        public static void Main(string[] args)
        {
            string greeting;
            greeting = SayHello();
            Console.WriteLine(greeting);
        }
    }
}
