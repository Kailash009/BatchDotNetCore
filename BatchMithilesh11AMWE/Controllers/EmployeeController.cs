using Microsoft.AspNetCore.Mvc;
using BatchMithilesh11AMWE.EmployeeDbOperation;
using BatchMithilesh11AMWE.Models;

namespace BatchMithilesh11AMWE.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            string email = HttpContext.Session.GetString("abc").ToString();
            TempData["email"] = email;
            List<Employee> empList= EmployeeOperation.getEmployees();
           return View(empList);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
