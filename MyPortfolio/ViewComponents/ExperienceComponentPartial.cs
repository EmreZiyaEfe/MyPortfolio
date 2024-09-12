using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;

namespace MyPortfolio.ViewComponents
{
    public class ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var result = portfolioContext.Experiences.ToList();
            return View(result);
        }
    }
}
