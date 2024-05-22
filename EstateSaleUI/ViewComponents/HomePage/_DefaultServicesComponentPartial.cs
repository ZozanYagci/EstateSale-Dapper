using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.HomePage
{
    public class _DefaultServicesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
