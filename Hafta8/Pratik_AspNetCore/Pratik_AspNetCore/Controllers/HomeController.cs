using Microsoft.AspNetCore.Mvc;

namespace Pratik_AspNetCore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
