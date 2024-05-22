using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
