using EstateSaleProject.Dtos.ProductDtos;

namespace EstateSaleProject.Repositories.LastProductsRepositories
{
    public interface ILast5ProductsRepository
    {
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id);
    }
}
