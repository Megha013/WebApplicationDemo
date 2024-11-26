using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    //[HttpGet]  -> It is optional
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> cities = new List<string>() { "Pune", "Banglore", "Mumbai", "Delhi", "Indore","Hyderabad" };
            ViewData["cities"] = new SelectList(cities);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form) //model binding
        {
            ViewBag.Name = form["personname"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];
            return View("Display");
        }
           
    }
}
