using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.skill = context.Skills.Count();
			ViewBag.messagesCount = context.Messages.Count();
			ViewBag.messagesUnread = context.Messages.Where(m => m.IsRead == false).Count();
			ViewBag.messagesRead = context.Messages.Where(m => m.IsRead == true).Count();
			ViewBag.experienceCount = context.Experiences.Count();
			ViewBag.portfolioCount = context.Portfolios.Count();
			ViewBag.toDoListDo = context.ToDoLists.Where(t => t.Status == true).Count();
            ViewBag.toDoListNotDo = context.ToDoLists.Where(t => t.Status == false).Count();

            return View();
		}
	}
}
