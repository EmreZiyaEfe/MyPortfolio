using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;

namespace MyPortfolio.ViewComponents
{
    public class SkillComponentPartial :ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var result = portfolioContext.Skills.ToList();
            return View(result);
        }
    }
}
