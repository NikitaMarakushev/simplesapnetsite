using Microsoft.AspNetCore.Mvc;

namespace simplesapnetsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
