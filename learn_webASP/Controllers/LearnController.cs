using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
 
namespace learn_webASP.Controllers
{
    public class learnController : Controller
    {
        // [HttpGet]
        // [Route("index")]
        // public string Index()
        // {
        //     return "Hello World, ha!";
        // }

        // // GET: /index/Welcome/ 
        // [HttpGet]
        // [Route("index/welcome")]
        // // public string Welcome()
        // // {
        // //     return "This is the Welcome action method...";
        // // }
        // //to pass some parameter information from the URL to the controller
        // // GET: /HelloWorld/Welcome/ 
        // // Requires using System.Text.Encodings.Web;
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }

        
        // [HttpGet]
        // [Route("index/welcome/{FirstName}/{LastName}/{Age}/{FavColor}")]
        // public JsonResult CallCard(string FirstName, string LastName, int Age, string FavColor)
        // {
        //     //This builds a JSON response with the given route parameters
        //     return Json(new {FirstName = FirstName, LastName = LastName, Age = Age, FavoriteColor = FavColor});
        // }

        // use view to render html file 
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            
            return View();
            
        }

        // use dictionary to render many texts in html 
        [HttpGet]
        [Route("index/FirstPage")]
        public IActionResult FirstPage(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            
        }
      

    }
}
