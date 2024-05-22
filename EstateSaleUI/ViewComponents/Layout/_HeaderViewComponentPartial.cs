using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
