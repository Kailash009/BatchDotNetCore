using BatchMithilesh11AMWE.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatchMithilesh11AMWE.Controllers
{
    public class RazorExController : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee();
            emp.EID = 101;
            emp.Name = "Ashish";
            emp.Age = 19;
            emp.City = "Noida";
            emp.Salary = 45000;
            return View(emp);
        }
    }
}
