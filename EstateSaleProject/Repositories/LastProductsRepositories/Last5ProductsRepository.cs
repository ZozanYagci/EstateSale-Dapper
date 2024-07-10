using Dapper;
using EstateSaleProject.Dtos.ProductDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.LastProductsRepositories
{
    public class Last5ProductsRepository : ILast5ProductsRepository
    {
        private readonly Context _context;

        public Last5ProductsRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id)
        {
            string query = "Select Top(5) P.ID, Title, Price, City, District, ProductCategory, AdvertisementDate" +
                " From Product P inner join Category C on P.ProductCategory=C.ID Where EmployeeID=@employeeId Order By P.ID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultLast5ProductWithCategoryDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
