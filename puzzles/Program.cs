using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    public class Program
    {
        public static int[] RandomArray()
        {
            int[] array = new int[10];
            int sum = 0;
            int max = 4; 
            int min = 26;
            Random randy = new Random();
            for (int i=0; i<10; i++)
            {
                int newval = randy.Next(5, 26);
                array[i] = newval;
                sum += newval;
                max = (max > newval) ? max : newval;
                min = (min < newval) ? min : newval;
            }
            Console.WriteLine("your sum is {0}, max is {1}, min is {2}", sum, max, min);
            return array;
             
        }

        public static string TossCoin()
        {
            Console.WriteLine(" toss a coin");
            Random flipper = new Random();
            int toss = flipper.Next(2);
            string result = (toss ==1)? "heads" : "tails";
            Console.WriteLine("you got {0}", result);
            return result;
        }

        public static double TossMultiCoins(int num)
        {
            int numheads = 0; 
            for (int count =0 ; count<num ; count++)
            {
                if (TossCoin()== "heads")
                {
                    numheads++;
                }
            }
            double resultat = (double)numheads/(double) num;
            return resultat;
        }

        public static string[] Names()
        {
            string[] peeps = new string[5] {"toddtstst", "samahha", "charle", "parissysy", "sydney"};
            peeps = Shuffler(peeps);

            // how to return an array that only include names greater than 5 char
            peeps = peeps.Where(name => name.Length>5).ToArray();
            return peeps;

        }

        public static string[] Shuffler(string[] peeps)
        {
            Random sel = new Random();
            int end = peeps.Length-1;
            for (int idx= end; idx>0; idx--)
            {
                int fdx = sel.Next(end);
                string temp = peeps[idx];
                peeps[idx] = peeps[fdx];
                peeps[fdx] = temp;
            }
            return peeps;

        }
        public static void Main(string[] args)
        {
            //RandomArray();
            //TossCoin();
            //TossMultiCoins(10);
            foreach(string name in Names())
            {
                Console.WriteLine(name);
            }
        }
    }
}
