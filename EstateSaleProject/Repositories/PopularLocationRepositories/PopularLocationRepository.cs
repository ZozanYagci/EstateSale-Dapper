using Dapper;
using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.PopularLocationDtos;
using EstateSaleProject.Dtos.ServiceDtos;
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

        public async Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {

            string query = "insert into PopularLocation(CityName, ImageUrl) values (@cityName, @imageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", createPopularLocationDto.CityName);
            parameters.Add("@imageUrl", createPopularLocationDto.ImageUrl);


            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeletePopularLocation(int id)
        {
            string query = "Delete From PopularLocation Where ID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@locationID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocation()
        {
            string query = "select *from PopularLocation";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdPopularLocationDto> GetPopularLocation(int id)
        {
            string query = "Select * From PopularLocation Where ID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@locationID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdPopularLocationDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            string query = "Update PopularLocation Set CityName=@cityName, ImageUrl=@imageUrl where ID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", updatePopularLocationDto.CityName);
            parameters.Add("@imageUrl", updatePopularLocationDto.ImageUrl);
            parameters.Add("@locationID", updatePopularLocationDto.ID);


            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
