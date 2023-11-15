using Microsoft.AspNetCore.Mvc;

namespace BatchMithilesh11AMWE.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            string email = HttpContext.Session.GetString("abc").ToString();
            TempData["email"] = email;
            return View();
        }
    }
}
