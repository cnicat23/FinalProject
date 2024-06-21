using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
