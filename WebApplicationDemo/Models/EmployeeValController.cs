using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Models
{
    public class EmployeeValController : Controller
    {
        public IActionResult RegisterEmp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterEmp(EmployeeVal emp)
        {
            return View("DisplayEmpVal");
        }
    }
}
