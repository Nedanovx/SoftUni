using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TextSplitter.Models;

namespace TextSplitter.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index(TextSplitViewModel textViewModel)
		{
			return View(textViewModel);
		}

		[HttpPost]
		public IActionResult Split(TextSplitViewModel textViewModel)
		{
			if(!ModelState.IsValid)
			{
				return RedirectToAction("Index", textViewModel);
			}

			string[] words = textViewModel.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
			string result = string.Join(Environment.NewLine, words);
			textViewModel.SplitText = result;
			return RedirectToAction("Index", textViewModel);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
