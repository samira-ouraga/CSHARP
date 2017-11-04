using System;

namespace RazorPagesLogReg.Models
{
    //The ID field is required by the database for the primary key.
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Confirm {get; set;}
    }
}