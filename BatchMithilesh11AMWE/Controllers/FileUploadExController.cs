using BatchMithilesh11AMWE.Filter;
using BatchMithilesh11AMWE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BatchMithilesh11AMWE.Controllers
{
    public class FileUploadExController : Controller
    {
        private readonly FileUpload _fp;
        public FileUploadExController(FileUpload fp)
        {
            _fp = fp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<FileUpload> employees=_fp.GetEmployeesWithImage();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FileUpload fileUpload)
        { 
            bool b=_fp.addEmployee(fileUpload);
            if(b==true)
            {
                TempData["insert"] = "<script>alert('Employee Added SuccessFully!!');</script>";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["insert"] = "<script>alert('Employee Failed!!');</script>";
            }
            return View();
        }
    }
}
