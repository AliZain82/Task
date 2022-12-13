
using Microsoft.AspNetCore.Mvc;

namespace AZ_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 