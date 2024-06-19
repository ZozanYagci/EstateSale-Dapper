using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
