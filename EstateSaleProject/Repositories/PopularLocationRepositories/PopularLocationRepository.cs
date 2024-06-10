using Dapper;
using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.PopularLocationDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;
        public PopularLocationRepository(Context context)
        {
                _context = context;
        }
        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "select *from PopularLocation";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }
    }
}
