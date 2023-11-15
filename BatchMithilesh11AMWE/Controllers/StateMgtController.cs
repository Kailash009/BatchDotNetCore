using Microsoft.AspNetCore.Mvc;
using BatchMithilesh11AMWE.Models;

namespace BatchMithilesh11AMWE.Controllers
{
    public class StateMgtController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("abc", "rites@gmail.com");
            //TempData["test"] = "Hello TempData!!!"; // contoller to view
            //string[] sports = { "Cricket", "FootBall", "Batminton", "Hockey", "Tennis", "BasketBall" };
            //ViewData["spt"] = sports;
            //Employee emp = new Employee();
            //emp.EID = 101;
            //emp.Name = "Rahul";
            //emp.Age = 19;
            //emp.City = "Noida";
            //emp.Salary = 4567.89;
            //ViewData["employee"] = emp;
            return View();
        }
        public IActionResult WriteCookie()
        {
            string email = HttpContext.Session.GetString("abc").ToString();
            TempData["email"] = email;
            return View();
        }

        [HttpPost]
        public IActionResult WriteCookie(Employee emp)
        {
            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddDays(2);  // Persistent Cookie
            Response.Cookies.Append("abc",emp.Name,cookie); // Write your data in Cookie.
            ViewBag.name = "Cookie Saved!";
            return View();
        }
        public IActionResult ReadCookie()
        {
            string email = HttpContext.Session.GetString("abc").ToString();
            TempData["email"] = email;
            return View();
        }
        [HttpPost]
        public IActionResult ReadCookie(Employee emp)
        {
            string username = Request.Cookies["abc"].ToString();
            if(username!=null)
            {
                ViewBag.usrname = username;
            }
            return View();
        }
    }
}
