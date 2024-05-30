using Dapper;
using EstateSaleProject.Dtos.ServiceDtos;
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
        public void CreateService(CreateServiceDto createServiceDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
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

        public Task<GetByIdServiceDto> GetService(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(UpdateServiceDto updateServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
