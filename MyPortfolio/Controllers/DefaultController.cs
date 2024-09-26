using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult SendMessage(Message message)
		{
			MyPortfolioContext context = new MyPortfolioContext();
			message.SendDate = DateTime.Now;
			context.Messages.Add(message);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
