using EstateSaleProject.Dtos.ToDoListDtos;

namespace EstateSaleProject.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto createToDoListDto);
        void DeleteToDoList(int id);
        void UpdateToDoList(UpdateToDoListDto updateToDoListDto);
        Task<GetByIdToDoListDto> GetToDoList(int id);

    }
}
