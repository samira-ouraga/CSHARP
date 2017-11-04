using System;
using System.Collections.Generic;
using System.Linq;

namespace classes_practice
{
// classes are used to keep track of info collected together abt entity
// define a class that contains property that define what the class has
// the class is a definition , I can create instances of that class I'll be working with an object
   class Car
   {
       public string Make{ get; set;}
       public string Model{get; set;}
       public int Year{get; set;}
       public string Color{get; set;}

        // the instance of class has the adress that is a reference of a car class in memory
        //memory is like bucket , we store values in that bucket(cpt memory), we hold on the that bucket with the handle 
        // handle(reference) here is mycar , which helps us acces the bucket(cpt memory)
        // when we let go of reference, we no longer access what's in the bucket
        

        //constructor is a method that allows to execute code when an instance of a class is created
        // to make a constructor look below

        public Car()
        {
            // i could load values from a config file, database
            Make = "Nissan";
        }

        //overloaded constructor , look at pcs line 90
        public Car(string make, string model, string color, int year)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }






    // get and set are used to create an instance of a property, get grabs it and set creates it   
        // public decimal DetermineMarketValue()
        // {
        //     decimal carValue;
        //     if(Year >1990)
        //     {
        //         carValue = 10000;
        //     }
        //     else
        //     {
        //         carValue = 2000;
        //     }
        //     return carValue;
        // }


        //prop tab tab to write property
   
   
   }

   
    
}