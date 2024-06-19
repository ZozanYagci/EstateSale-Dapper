using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
