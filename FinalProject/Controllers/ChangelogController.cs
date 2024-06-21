using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	public class ChangelogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
