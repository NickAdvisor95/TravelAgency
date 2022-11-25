using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
