using System;

namespace human_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Samira = new Human("samira");
            // Console.WriteLine(Samira._name);
            // Console.WriteLine(Samira._intelligence);
            //Console.WriteLine("my name is {0}, my health is {1}", Samira._name, Samira._health);

            Human Marina = new Human("marina", 12, 18, 25, 28);
            //Console.WriteLine("I am {0}, my strength is {1}, my intelligence is {2}, my dexteriety is at {3} and my health is at {4}", Marina._name, Marina._strength, Marina._intelligence, Marina._dexterity, Marina._health);

            Marina.Attack(Samira);
            Console.WriteLine("{0} attacked {1}, the attacked  health is now at {2}", Marina._name, Samira._name, Samira._health);

        
        }


    }
}
