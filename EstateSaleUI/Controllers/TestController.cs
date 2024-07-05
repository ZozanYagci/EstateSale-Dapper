using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
