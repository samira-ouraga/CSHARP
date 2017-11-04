using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Loginreg.Models;
using DbConnection;

namespace Loginreg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

          
    //to handle registration , the route can be anything since asp will catch the function in html 
        [HttpPost]
        [Route("/Reg/")]
        // register takes a user instance as input
        public IActionResult Register(RegisterForm user)
        {

            //if validations in register class are valid 
            if(ModelState.IsValid)
            {
                // query to add new user in function param to database 
                DbConnector.Execute($"INSERT INTO users(name, email, password, created_at, updated_at) VALUES ('{user.Name}', '{user.Email}', '{user.Password}', NOW(), NOW());");
        
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        // this method is for login 
        [HttpPost]
        [Route("/login/")]
        //here login function takes the user class as input with it's spec prop
        public IActionResult Login(LoginForm user)
        {
            //the user here is an instance of the login class but it only take the login form prop

            //look  for user in database by comparing instance of login email and psswrd to db 
            List<Dictionary<string, object>> theusers = DbConnector.Query($"SELECT * FROM users WHERE email='{user.logemail}' AND password='{user.logpassword}'");
            // if you find the user 
            if(theusers.Count > 0)
            {
                //save the valid user to session
                HttpContext.Session.SetInt32("id", (int)theusers[0]["id"]);
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpGet]
        [Route("Success")]
        public IActionResult Success()
        {
            
            ViewBag.Message = "You are logged in ";

            return View();
        }


      

    
    }
}
