using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult Index()
		{
			var results = context.ToDoLists.ToList();
			return View(results);
		}

		[HttpGet]
		public IActionResult CreateToDoList() 
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			context.ToDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var result = context.ToDoLists.Find(id);
			context.ToDoLists.Remove(result);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var result = context.ToDoLists.Find(id);
			return View(result);
		}

		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList) 
		{
			context.ToDoLists.Update(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeToDoListStatusToTrue(int id)
		{
			var result = context.ToDoLists.Find(id);
			result.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeToDoListStatusToFalse(int id)
		{
			var result = context.ToDoLists.Find(id);
			result.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
