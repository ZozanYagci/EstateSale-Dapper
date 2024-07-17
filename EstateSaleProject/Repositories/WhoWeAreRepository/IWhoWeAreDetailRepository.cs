using EstateSaleProject.Dtos.CategoryDtos;
using EstateSaleProject.Dtos.WhoWeAreDetailDtos;
using EstateSaleProject.Dtos.WhoWeAreDtos;

namespace EstateSaleProject.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetail();
        Task CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        Task DeleteWhoWeAreDetail(int id);
        Task UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<GetByIdWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
