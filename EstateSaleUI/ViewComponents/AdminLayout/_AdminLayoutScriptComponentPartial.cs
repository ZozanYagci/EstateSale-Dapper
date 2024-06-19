using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
