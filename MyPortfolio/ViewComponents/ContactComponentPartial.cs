using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccess.Context;

namespace MyPortfolio.ViewComponents
{
    public class ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactTitle = context.Contacts.Select(x => x.Title).SingleOrDefault();
            ViewBag.contactDescription = context.Contacts.Select(x => x.Description).SingleOrDefault();
            ViewBag.contactEmail = context.Contacts.Select(x => x.Email).SingleOrDefault();
            ViewBag.contactPhone = context.Contacts.Select(x => x.Phone).SingleOrDefault();
            ViewBag.contactAddress = context.Contacts.Select(x => x.Address).SingleOrDefault();

            return View();
        }
    }
}
