using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DbConnection;
using System.Linq;

namespace FormsAndDb.Controllers
{
    public class CarController : Controller
    {

        // GET: /WHERE FORM IS/
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /WHERE RESULTS DISPLAY/ 

        [HttpGet]
        [Route("Display")]
        public IActionResult Display()
        {
            // to display data from db
            string query = "SELECT * FROM cars";
            var Allmycars = DbConnector.Query(query);
            ViewBag.Allmycars = Allmycars;
            return View();
        }

        //ANOTHER ONE TO PROCESS THE FORM AND WILL REDIRECT TO DISPLAY PAGE
        [HttpPost]
        [Route("/Process")]
        public IActionResult Process(string name, string make)
        {
            //Add the name and make  to the database
            string query = $"INSERT INTO cars(name, make) VALUES ('{name}', '{make}');";
            DbConnector.Execute(query);
            return RedirectToAction("Display");
        }
    
    }  

}