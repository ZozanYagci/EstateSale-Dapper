using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
