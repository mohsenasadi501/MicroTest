using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    public class PlatformsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
