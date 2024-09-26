using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var results = context.Messages.ToList();
			return View(results);
		}

		public IActionResult ChangeIsReadToTrue(int id) 
		{
			var result = context.Messages.Find(id);
			result.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult ChangeIsReadToFalse(int id)
		{
			var result = context.Messages.Find(id);
			result.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult DeleteMessage(int id)
		{
			var result = context.Messages.Find(id);
			context.Messages.Remove(result);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var result = context.Messages.Find(id);
			return View(result);
		}

		
	}
}
