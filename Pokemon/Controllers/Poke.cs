using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace Pokemon.Controllers
{
    public class PokeController : Controller
    {
        [HttpGet]
        [Route("Pokemon/{id}")]
        public IActionResult GetInfo(int id)
        {
            var PokeObject = new Pokeinfo();

            WebRequest.GetPokeinfoDataAsync(id, PokeResponse => {
                PokeObject = PokeResponse;
            }).Wait();
            ViewBag.Pokeinfo = PokeObject;
            return View();
        }
    }
}