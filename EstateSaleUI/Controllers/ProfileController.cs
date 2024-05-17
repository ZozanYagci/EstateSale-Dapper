using Microsoft.AspNetCore.Mvc;

namespace EstateSaleUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
