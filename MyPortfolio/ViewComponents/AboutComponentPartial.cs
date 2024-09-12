using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;

namespace MyPortfolio.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(t => t.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(s => s.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(d => d.Detail).FirstOrDefault();
            return View();
        }
    }
}
