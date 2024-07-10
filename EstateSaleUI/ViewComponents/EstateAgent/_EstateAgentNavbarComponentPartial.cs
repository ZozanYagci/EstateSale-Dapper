using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.ViewComponents.EstateAgent
{
    public class _EstateAgentNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
