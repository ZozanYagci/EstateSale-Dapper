using EstateSaleProject.Dtos.PopularLocationDtos;

namespace EstateSaleProject.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {

        Task<List<ResultPopularLocationDto>> GetAllPopularLocation();
        Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocation(int id);
        Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIdPopularLocationDto> GetPopularLocation(int id);
    }
}
