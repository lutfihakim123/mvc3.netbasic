using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var obj = new { id = 1 , Name = "Lutfi"};   
            return View(obj);
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
    