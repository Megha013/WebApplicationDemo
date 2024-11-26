using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            List<string> branch = new List<string>() { "IT", "CS", "EE", "Civil", "ME", "EC" };
            ViewData["branch"] = new SelectList(branch);
            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form) 
        {
            ViewBag.RollNo = form["rollno"];
            ViewBag.Name = form["name"];
            ViewBag.Branch = form["branch"];
            ViewBag.Year = form["year"];
            return View("DisplayDetails");
        }
    }
}
