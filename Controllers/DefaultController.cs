using Microsoft.AspNetCore.Mvc;

namespace baseapp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
