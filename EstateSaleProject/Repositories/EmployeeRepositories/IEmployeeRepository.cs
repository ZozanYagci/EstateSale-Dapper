using EstateSaleProject.Dtos.CategoryDtos;
using EstateSaleProject.Dtos.EmployeeDtos;

namespace EstateSaleProject.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto employeeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDto employeeDto);
        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
