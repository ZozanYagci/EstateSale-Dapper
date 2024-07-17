using Dapper;
using EstateSaleProject.Dtos.ProductImageDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;

        public ProductImageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id)
        {
            string query = "Select * From ProductImage Where ID=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<GetProductImageByProductIdDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
