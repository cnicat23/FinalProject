using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	public class InstructionsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
