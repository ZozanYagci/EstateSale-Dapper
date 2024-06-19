using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
