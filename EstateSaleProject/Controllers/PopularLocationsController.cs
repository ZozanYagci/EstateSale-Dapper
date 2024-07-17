using EstateSaleProject.Dtos.PopularLocationDtos;
using EstateSaleProject.Repositories.PopularLocationRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateSaleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _locationRepository;
        public PopularLocationsController(IPopularLocationRepository locationRepository)
        {
                _locationRepository = locationRepository;
        }

        [HttpGet]   
        public async Task<IActionResult> PopularLocationList()
        {
            var value= await _locationRepository.GetAllPopularLocation();
            return Ok(value);   
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            await _locationRepository.CreatePopularLocation(createPopularLocationDto);
            return Ok("Lokasyon kısmı başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            await _locationRepository.DeletePopularLocation(id);
            return Ok("Lokasyon kısmı başarılı bir şekilde silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            await _locationRepository.UpdatePopularLocation(updatePopularLocationDto);
            return Ok("Lokasyon kısmı başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var value = await _locationRepository.GetPopularLocation(id);
            return Ok(value);
        }
    }
}
