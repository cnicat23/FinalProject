using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class FashionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
