using Microsoft.AspNetCore.Mvc;
using BatchMithilesh11AMWE.Models;

namespace BatchMithilesh11AMWE.Controllers
{
    public class HelperExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee empObj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ShowEmployee", empObj);
            }
            else
            {
                return View();               
            }
        }
        public IActionResult ShowEmployee(Employee emp)
        {
            return View(emp);
        }
    }
}
