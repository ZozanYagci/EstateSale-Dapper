using Dapper;
using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.ProductDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;
        public BottomGridRepository(Context context)
        {
                _context = context;
        }
        public void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "select *from BottomGrid";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
