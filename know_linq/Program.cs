using System;
using System.Collections.Generic;
using System.Linq;

namespace know_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            //LINQ query
            //find all bmw 
            // var bmws = from car in myCars
            //            where car.Make == "BMW"
            //            && car.Year == 2010
            //            select car;

            //order list of cars
            // var orderedcars = from car in myCars
            //                 orderby car.Year descending
            //                 select car;
            
            // how to get type of elt selected from json file if i don't know
            var newCars = from car in myCars
                            where car.Make == "BMW"
                            && car.Year == 2010
                            select new {car.Make, car.Model};
                            
            // to print datatype
            System.Console.WriteLine(newCars.GetType());




            //LINQ method
            //find all bms 
            var bmws = myCars.Where(p =>p.Make == "BMW" && p.Year == 2010);

            // order cars 

            var orderedcars = myCars.OrderByDescending(p =>p.Year);
            //p=>.. is a lambda expression , saying from given p , only return those instance p (of car) that satisfy cdts cited after
            // the var keyword says we'll let the compiler figure out the correct datatype 
            // used bcz we don't know type of data we want from json file
            foreach(var car in orderedcars)
            {
                //System.Console.WriteLine("{0}, {1}, {2}", car.Model, car.VIN, car.Year);
            }



            
            Console.ReadLine();
            
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

}
