using EstateSaleProject.Dtos.ProductImageDtos;

namespace EstateSaleProject.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
