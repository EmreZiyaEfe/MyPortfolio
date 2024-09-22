using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;
using MyPortfolio.DataAccess.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var results = context.Experiences.ToList();
            return View(results);
        }

        [HttpGet]
        public IActionResult CreateExperience() 
        {
            return View();
        }

        [HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
		}

        public IActionResult DeleteExperience(int id)
        {
            var result = context.Experiences.Find(id);
            context.Experiences.Remove(result);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var result = context.Experiences.Find(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
