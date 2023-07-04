using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello";
        }
    }
}
