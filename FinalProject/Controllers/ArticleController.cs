using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
	public class ArticleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
