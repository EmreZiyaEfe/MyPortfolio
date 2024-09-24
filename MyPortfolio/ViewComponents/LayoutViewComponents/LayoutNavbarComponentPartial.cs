using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class LayoutNavbarComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.ToDoLists.Where(T => T.Status == false).Count();
			var results = context.ToDoLists.Where(t => t.Status == false).ToList();
			return View(results);
		}
	}
}
