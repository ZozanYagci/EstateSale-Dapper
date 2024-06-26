using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.PopularLocationDtos;
using EstateSaleProject.Dtos.PopularLocationDtos;

namespace EstateSaleProject.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {

        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();

        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIdPopularLocationDto> GetPopularLocation(int id);
    }
}
