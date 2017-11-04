using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;
using know_session.Models;


namespace know_session.Controllers
{
    public class TheSessionController : Controller
    {
        

        public IActionResult Index()
        {
            // if string set here , it has a key and value pair.
            HttpContext.Session.SetString("Test", "Ben Rules!");

            //to get values get the key
            ViewBag.myString = HttpContext.Session.GetString("Test");

            //if integer , set it this  way
            HttpContext.Session.SetInt32("mynumber", 2865);

            //to get it do this 
            ViewBag.myNum = HttpContext.Session.GetInt32("mynumber");

            // if an object, do below object will be my CLASS IN model
            if(HttpContext.Session.GetObjectFromJson<Movie>("mymovie") == null)
            {
                HttpContext.Session.SetObjectAsJson("mymovie", new Movie());
            }

            
            ViewBag.MyMovie = HttpContext.Session.GetObjectFromJson<Movie>("mymovie");
            
            //how to change values of properties here, assign a new variable to it
            Movie newMovie = HttpContext.Session.GetObjectFromJson<Movie>("mymovie");
            newMovie.Title = "my different title";
            newMovie.Genre = "my new genre";
            newMovie.Price = 871; 

            HttpContext.Session.SetObjectAsJson("othermovie", newMovie);
            ViewBag.otherMovie = newMovie;
            return View();
        }


       
    }
        // if model, use object to grab sessions , always have this code below controller class
        public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}