using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
