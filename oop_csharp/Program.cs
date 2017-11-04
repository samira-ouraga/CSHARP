using System;

namespace oop_csharp
{
    class Program
    {
        // to create an instance of that class , come here 
        static void Main(string[] args)
        {
            // this is on child of vehicle, taking all from them, and giving them sep values 
            Vehicle myCar = new Vehicle(3);
            Vehicle myBike = new Vehicle(1);

            // how to read the values 
            Console.WriteLine(myCar.numPassenger);
            Console.WriteLine(myBike.numPassenger);

            // how to create the function with values on each instance
            myBike.Move(1.3);
            myCar.Move(4.5);

            Console.WriteLine("My bike went {0} miles and my car went {1} miles", myBike.distance, myCar.distance);
        }
    }
}
