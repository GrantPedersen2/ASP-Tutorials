using HelloWorldMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage()
            {
                Message = "Hello World"
            };
            return View(obj);
        }

        //Overload called when HTML form is POSTed to server...
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message changed.";
            return View(obj);
        }
    }
}
