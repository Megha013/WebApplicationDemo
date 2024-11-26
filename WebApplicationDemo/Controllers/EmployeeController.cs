using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            TempData["message"] = "Hello from employee controller";
            TempData.Keep("message");
            ViewData["message"] = "Hello from controller";
            List<string> names = new List<string>() { "John", "Nick", "Joe", "Barbara", "Justin", "Kiara" };
            ViewData["names"] = names;
            ViewBag.Names = names;
        
            List<Employee> employees = new List<Employee>() { 
                new Employee{Id=1,Name="John",Department="Development",Salary=50000 },
                new Employee{Id=2,Name="Selena",Department="Testing",Salary=40000 },
                new Employee{Id=3,Name="Nick",Department="Tech Support",Salary=20000 },
                new Employee{Id=4,Name="Joe",Department="Medical",Salary=70000 },
                new Employee{Id=5,Name="Justin",Department="Law",Salary=30000 }
            };
            ViewData["emplist"] = employees;
            ViewBag.Employees = employees;
            return View();
        }
    }
}
