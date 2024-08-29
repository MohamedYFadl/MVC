using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index() {

            //return Content("Mohamed Yasser");
            return View();
        }
        public IActionResult AboutUs()
        {
            //return Redirect("https://github.com/MohamedYFadl");
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
