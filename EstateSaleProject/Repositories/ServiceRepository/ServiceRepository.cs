using Dapper;
using EstateSaleProject.Dtos.ServiceDtos;
using EstateSaleProject.Dtos.WhoWeAreDetailDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {

        private readonly Context _context;
        public ServiceRepository(Context context)
        {
                _context = context; 
        }
        public async void CreateService(CreateServiceDto createServiceDto)
        {
            string query = "insert into Service(Name, Status) values (@name, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createServiceDto.Name);
            parameters.Add("@status", true);
          

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteService(int id)
        {
            string query = "Delete From Service Where ID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdServiceDto> GetService(int id)
        {
            string query = "Select * From Service Where ID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdServiceDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDto updateServiceDto)
        {
            string query = "Update Service Set Name=@name, Status=@status where ID=@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateServiceDto.Name);
            parameters.Add("@status", updateServiceDto.Status);
            parameters.Add("@serviceID", updateServiceDto.ID);
            

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }
    }
}
