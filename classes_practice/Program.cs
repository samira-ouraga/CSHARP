using System;
using System.Collections.Generic;
using System.Linq;

namespace classes_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car here is the the datatype of the object myCar
            // like we do int sam 
            // new car means put the instance in the memory bucket 
            // new is the factory that builds the new car and put in pattern
            Car  myCar = new Car();
            // myCar.Make = "oldMobile";
            // myCar.Model = "cutlas supreme";
            // myCar.Year = 1986;
            // myCar.Color = "silver";

            Console.WriteLine("{0}, {1}, {2}, {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);


            // create a reference(handle) of car but don't save it to bucket Car
            // it is not attached to the bucket of cars in the laptop memory
            Car myOtherCar;

            // we took one handle and created a second handle, so they are both referencing the same memory.
            myOtherCar = myCar;
            
            //this will print the same values as mycar
            // System.Console.WriteLine("{0}, {1}, {2}, {3},",
            //     myOtherCar.Make, 
            //     myOtherCar.Model, 
            //     myOtherCar.Year, 
            //     myOtherCar.Color
            // );
            // change the model 
            // myOtherCar.Model = "98";
            //  System.Console.WriteLine("{0}, {1}, {2}, {3},",
            //     myOtherCar.Make, 
            //     myOtherCar.Model, 
            //     myOtherCar.Year, 
            //     myOtherCar.Color
            // );

            //set an object to null means , we'll remove one handle from bucket
            //myOtherCar = null;
            /*System.Console.WriteLine("{0}, {1}, {2}, {3},",
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color
            );
            */
            // to remove all handles to Car in bucket , since all refs are gne, the object will be removed from bucket after some time w/o handles
            // but this is dangerous if the Car holds other info  we need
            //myCar = null;


            

            // when function is wriiten here print like this
            //decimal value = DetermineMarketPrice(myCar);
            // what is C?
            //Console.WriteLine("{0:C}", value);


            // when method is written in class page do like this
            // how to use the method from car cs to print var returned there
            //Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
        
        }

            //functions which are not methods go  here
        public static decimal DetermineMarketPrice(Car car)
            {
                // what is M?
                decimal carValue = 100.0M;
                return carValue;
            }

        //contructor r used to initialize the values of that given object
        // as soon as I create an instance ie default value

        //after overloading constructor, you can populate it like below

        Car myThirdcar = new Car("ford", "ste", "white", 204);
        

    }
}
