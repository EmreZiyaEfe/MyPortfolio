using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
