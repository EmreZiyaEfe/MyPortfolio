using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
	public class SkillController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var results = context.Skills.ToList();
			return View(results);
		}

		[HttpGet]
		public IActionResult CreateSkill()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSkill(int id)
		{
			var result = context.Skills.Find(id);
			context.Skills.Remove(result);
			context.SaveChanges();
			return RedirectToAction("Index");

		}

		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var result = context.Skills.Find(id);
			return View(result);
		}

		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			context.Skills.Update(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
