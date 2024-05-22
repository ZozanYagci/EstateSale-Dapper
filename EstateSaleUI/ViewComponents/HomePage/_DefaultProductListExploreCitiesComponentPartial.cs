using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.HomePage
{
    public class _DefaultProductListExploreCitiesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
