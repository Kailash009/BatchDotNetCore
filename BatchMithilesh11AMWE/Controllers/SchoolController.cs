using BatchMithilesh11AMWE.SchoolDbOperation;
using Microsoft.AspNetCore.Mvc;
using BatchMithilesh11AMWE.Models;

namespace BatchMithilesh11AMWE.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            string email = HttpContext.Session.GetString("abc").ToString();
            TempData["email"] = email;
            School school=SchoolOperations.getSchool();
            return View(school);
        }
    }
}
