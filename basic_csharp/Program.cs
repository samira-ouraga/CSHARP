using System;
using System.Collections.Generic;
using System.Linq;

namespace basic_csharp
{
    public class Program
    {
        public static void Print1to255()
        {
            for(int val=1; val <= 9; val++)
            {
                Console.WriteLine(val);
            }
            
        }

        public static void PrintOdds()
         {
            for(int val = 1; val < 10; val++) {
                if(val % 2 == 1) {
                    Console.WriteLine(val);
                }
            }
        }
        public static void ArrayIterate(int[] arr)
        {
            string output = "[";
            for(int idx = 0; idx < arr.Length; idx++) 
            {
                output += arr[idx] + ", ";
            }
            output += "]";
            Console.WriteLine(output);
        }
        
        public static void Main(string[] args)
        {
            Print1to255();
            PrintOdds();
            int[] myArr = new int[6] {1,3,5,7,9,13};
            ArrayIterate(myArr);
        }


    }
}
