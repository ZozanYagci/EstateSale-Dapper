using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
