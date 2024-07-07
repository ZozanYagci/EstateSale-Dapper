using EstateSaleProject.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateSaleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCreateController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateToken(GetCheckAppUSerViewModel model)
        {
            var values=JwtTokenGenerator.GenerateToken(model);  
            return Ok(values);
        }

    }
}
