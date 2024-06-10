using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.PopularLocationDtos;

namespace EstateSaleProject.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {

        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}
