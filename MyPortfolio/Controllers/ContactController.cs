using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class ContactController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var results = context.Contacts.ToList();
			return View(results);
		}

		[HttpGet]
		public IActionResult UpdateContact(int id)
		{
			var result = context.Contacts.Find(id);
			return View(result);
		}

		[HttpPost]
		public IActionResult UpdateContact(Contact contact)
		{
			context.Contacts.Update(contact);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
