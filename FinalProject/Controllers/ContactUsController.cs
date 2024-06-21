using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	public class ContactUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
