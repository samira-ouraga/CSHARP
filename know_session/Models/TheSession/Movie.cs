using System;

namespace know_session.Models
{
    public class Movie
    {
        public string Title { get; set; }
        
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public Movie()
        {
            Title = "My title";
            Genre = "My genre";
            Price = 24.0M ; 
        }
    }

    
}