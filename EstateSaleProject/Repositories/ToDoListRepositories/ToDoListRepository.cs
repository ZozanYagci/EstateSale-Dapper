using Dapper;
using EstateSaleProject.Dtos.ToDoListDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.ToDoListRepositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;
        public ToDoListRepository(Context context)
        {
                _context = context;
        }
        public Task CreateToDoList(CreateToDoListDto createToDoListDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoList()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdToDoListDto> GetToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoList(UpdateToDoListDto updateToDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
