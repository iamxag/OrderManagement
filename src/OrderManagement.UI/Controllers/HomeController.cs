using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
