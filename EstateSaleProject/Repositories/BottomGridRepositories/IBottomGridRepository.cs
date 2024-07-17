using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.CategoryDtos;

namespace EstateSaleProject.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGrid();
        Task CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
