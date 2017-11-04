using System.ComponentModel.DataAnnotations;


namespace Loginreg.Models
{
    //BaseEntity class that all of our Model classes inherit from. 
    //BaseEntity serves as a generic reference that we can use to distinguish our Models from all other classes.
     public abstract class BaseEntity {

     }
    //the first two classes are used to validate the registration 
    public class RegisterForm: BaseEntity
    {
        [Required]
        [Display(Name="Name")]
        [MinLength(2)]
        public string Name {get; set;}
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Invalid Email")]
        [Display(Name="Email")]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        [MinLength(8)]
        public string Password {get; set;}

        [Display(Name="Confirm")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get; set;}

    }
    public class LoginForm: BaseEntity
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        public string logemail {get;set;}

        [Required]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        public string logpassword{get;set;}
    }

    // the user class with inherit from classes above 
    public class User:BaseEntity
    {
        public RegisterForm Registerdetails {get;set;}
        public LoginForm Logindetails {get;set;}
    }
}