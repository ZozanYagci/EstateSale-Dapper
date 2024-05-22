using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.HomePage
{
    public class _DefaultOurClientsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
