using EstateSaleProject.Repositories.ServiceRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateSaleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceController(IServiceRepository serviceRepository)
        {
                _serviceRepository = serviceRepository;
        }
        [HttpGet]   
        public async Task<IActionResult> GetServiceList()
        {
            var value= await _serviceRepository.GetAllServiceAsync();
            return Ok(value);
        }
    }
}
