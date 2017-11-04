using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;


namespace dojodachiapp
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            // if object (instance of class dp isn't saved in session)
            if(HttpContext.Session.GetObjectFromJson<Dojodachipet>("Dojodachi") == null)
            {
                // make an instance of that class, save it to session
                HttpContext.Session.SetObjectAsJson("Dojodachi", new Dojodachipet());
            }

            ViewBag.Message = "You got a brand new Dojodachi!";
            ViewBag.GameStatus = "running";
            ViewBag.Reaction = "";

            return View();
        }

        [HttpPost]
        [Route("performAction")]
        public IActionResult PerformAction(string action)
        {
            //as I click on any action, grab object made in session and assign it to new var
            Dojodachipet EditDachi = HttpContext.Session.GetObjectFromJson<Dojodachipet>("Dojodachi");
            //this is the random amount of fullness
            Random RandNum = new Random();
            ViewBag.GameStatus = "running";
            switch(action)
            {
                // you will manipulate the new variable
                //I click feed button in form , the new dachi will have thhose diff prop
                case "feed":
                    if(EditDachi.Meals > 0){
                        EditDachi.Meals -= 1;
                        if(RandNum.Next(0, 4) > 0)
                        {
                            //fullness prop will increase by rand num
                            EditDachi.Fullness += RandNum.Next(5, 11);
                            ViewBag.Reaction = ":)";
                            ViewBag.Message = "Dojodachi enjoyed the meal!";
                        }
                        else
                        {
                            ViewBag.Reaction = ":(";
                            ViewBag.Message = "Dojodachi didn't like the food very much...";
                        }
                    }
                    else
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "You don't have any food for your Dojodachi!";
                    }
                    break;
                // as i click button play 
                case "play":
                    if(EditDachi.Energy > 4)
                    {
                        EditDachi.Energy -= 5;
                        if(RandNum.Next(0, 4) > 0)
                        {
                            //happiness prop will increase by rand num
                            EditDachi.Happiness += RandNum.Next(5, 11);
                            ViewBag.Reaction = ":)";
                            ViewBag.Message = "Dojodachi had fun playing!";
                        }
                        else
                        {
                            ViewBag.Reaction = ":(";
                            ViewBag.Message = "Looks like Dojodachi didn't want to play...";
                        }
                    }
                    else
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "Not enough energy...";
                    }

                    break;
                case "work":
                    if(EditDachi.Energy > 4)
                    {
                        EditDachi.Energy -= 5;
                        EditDachi.Meals += RandNum.Next(1, 4);
                        ViewBag.Reaction = ":)";
                        ViewBag.Message = "You worked hard to feed your Dojodachi!";
                    }
                    else
                    {
                        ViewBag.Reaction = ":(";
                        ViewBag.Message = "Not enough energy...";
                    }
                    break;
                case "sleep":
                    EditDachi.Energy += 15;
                    EditDachi.Fullness -= 5;
                    EditDachi.Happiness -= 5;
                    ViewBag.Reaction = ":)";
                    ViewBag.Message = "Dojodachi seems well rested.";
                    break;
                default:
                    // Handle unxpected values submitted from form
                    ViewBag.Reaction = "XXXXXXXXXXXXXX";
                    ViewBag.Message = "There's a glitch in the martix...";
                    break;

            }
            if(EditDachi.Fullness < 1 || EditDachi.Happiness < 1)
            {
                ViewBag.Reaction = "X(";
                ViewBag.Message = "Oh no! Your Dojodachi has died...";
                ViewBag.GameStatus = "over";
            }
            else if(EditDachi.Fullness > 99 && EditDachi.Happiness > 99)
            {
                ViewBag.Reaction = ":D";
                ViewBag.Message = "Congratulations! You win!";
                ViewBag.GameStatus = "over";
            }
            //Replace assign old dict to new dict, this is the only way to add new key,value w/o replacing the old ones
            HttpContext.Session.SetObjectAsJson("Dojodachi", EditDachi);
            ViewBag.Dojodachi = EditDachi;
            return View("Index");
        }

        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
    //ALWAYS HAVE THIS
        public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
