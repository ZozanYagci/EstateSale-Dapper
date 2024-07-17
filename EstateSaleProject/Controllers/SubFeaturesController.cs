using EstateSaleProject.Repositories.SubFeatureRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateSaleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeaturesController : ControllerBase
    {
        private readonly ISubFeatureRepository _subFeatureRepository;

        public SubFeaturesController(ISubFeatureRepository subFeatureRepository)
        {
            _subFeatureRepository = subFeatureRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetSubFeatureList()
        {
            var values=await _subFeatureRepository.GetAllSubFeatureAsync();
            return Ok(values);  
        }
    }
}
