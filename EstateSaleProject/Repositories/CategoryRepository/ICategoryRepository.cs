using EstateSaleProject.Dtos.CategoryDtos;

namespace EstateSaleProject.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategory();
        Task CreateCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIdCategoryDto> GetCategory(int id);
    }
}
