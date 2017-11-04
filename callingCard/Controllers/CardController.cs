using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
                // Inside your Controller class
        // Other code
        
        // A GET method
        [HttpGet]
        [Route("index")]
        public JsonResult DisplayInt()
        {
            var AnonObject = new {
                                FirstName = "Samira",
                                LastName = "Aquato",
                                Age = 10
                            };
            return Json(AnonObject);
        }
        

    }
}
