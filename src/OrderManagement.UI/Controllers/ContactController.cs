using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
