using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
