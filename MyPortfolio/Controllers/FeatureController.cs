using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class FeatureController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var result = context.Features.ToList();
			return View(result);
		}

		[HttpGet]
		public IActionResult UpdateFeature(int id)
		{
			var result = context.Features.Find(id);
			return View(result);
		}

		[HttpPost]
		public IActionResult UpdateFeature(Feature feature)
		{
			context.Features.Update(feature);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
