using System;
using System.Collections.Generic;

namespace collections_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
            string[] stringArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            // bool[] boolArray = new bool[10];
            // for(int i = 0; i < 10; i += 2)
            // {
            //     boolArray[i] = true;
            // }

            // int[,] table = new int[10,10];
            // // first one is for looping through first the array of length10, 2nd loop is for second array next to it 
            // for(int x = 0; x < 10; x++)
            // {
            //     for(int y = 0; y < 10; y++)
            //     {
            //         table[x, y] = (x + 1) * (y + 1);
            //     }
            // }

            // for(int x = 0; x < 10; x++)
            // {
            //     string display = "[ ";
            //     for(int y = 0; y < 10; y++)
            //     {
            //         display += table[x, y] + ", ";
            //         //Add an extra space for single digit values
            //         if(table[x,y] < 10)
            //         {
            //             display += " ";
            //         }
            //     }
            //     display += "]";
            //     Console.WriteLine(display);
            // }

            List<string> flavors = new List<string>(); 
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("raisin");
            flavors.Add("berry");

            // Console.WriteLine(flavors.Count);
            // Console.WriteLine(flavors[3]);
            // flavors.RemoveAt(3);
            // Console.WriteLine(flavors.Count);


            Dictionary <string,string> UserInfo = new Dictionary<string,string>();
            Random rand = new Random();
            foreach(string name in stringArray)
            {
                UserInfo[name] = flavors[rand.Next(flavors.Count)];
            }
            
            Console.WriteLine("Users and their favor ice cream flavors:");
            foreach(KeyValuePair<string, string> info in UserInfo)
            {
                Console.WriteLine(info.Key + " - " + info.Value);
            }



        }
    }
}
