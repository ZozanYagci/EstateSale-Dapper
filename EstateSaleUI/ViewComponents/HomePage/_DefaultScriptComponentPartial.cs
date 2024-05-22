using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.HomePage
{
    public class _DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
