using Dapper;
using EstateSaleProject.Dtos.CategoryDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
                _context = context;
        }
        public async Task CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category(Name, Status) values (@categoryName, @categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.Name);
            parameters.Add("@categoryStatus", true);
            using(var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCategory(int id)
        {
            string query = "delete from Category where ID=@categoryID";
            var parameters= new DynamicParameters();
            parameters.Add("@categoryID", id);
            using (var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategory()
        {
            string query = "Select * From Category";
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultCategoryDto>(query);   
                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "select*from Category where ID=@categoryId";
            var parameters=new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection=_context.CreateConnection())
            {
              var values=  await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category Set Name=@categoryName, Status=@categoryStatus where ID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.Name);
            parameters.Add("@categoryStatus", categoryDto.Status);
            parameters.Add("@categoryID", categoryDto.ID);
          
            using(var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
