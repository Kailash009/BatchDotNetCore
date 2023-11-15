using BatchMithilesh11AMWE.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatchMithilesh11AMWE.Controllers
{
    public class ValidationExController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer cusObj) // Server
        {
            if(ModelState.IsValid)  // Check server side Validation
            {
                // Save Record into Database.
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error in Customer Model");
            }
            return View();
        }
    }
}
