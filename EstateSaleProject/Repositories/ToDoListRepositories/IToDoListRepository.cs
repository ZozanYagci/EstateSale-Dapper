using EstateSaleProject.Dtos.ToDoListDtos;

namespace EstateSaleProject.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDto createToDoListDto);
        Task DeleteToDoList(int id);
        Task UpdateToDoList(UpdateToDoListDto updateToDoListDto);
        Task<GetByIdToDoListDto> GetToDoList(int id);

    }
}
