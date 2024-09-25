using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class PortfolioController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var result = context.Portfolios.ToList();
			return View(result);
		}

		[HttpGet]
		public IActionResult CreatePortfolio()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeletePortfolio(int id)
		{
			var result = context.Portfolios.Find(id);
			context.Portfolios.Remove(result);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var result = context.Portfolios.Find(id);
			return View(result);
		}

		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
