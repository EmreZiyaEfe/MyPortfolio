using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var result = context.Abouts.ToList();
			return View(result);
		}

		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var result = context.Abouts.Find(id);
			return View(result);
		}

		[HttpPost]
		public IActionResult UpdateAbout(About about) 
		{
			context.Abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
