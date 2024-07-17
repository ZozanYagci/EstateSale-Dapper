using EstateSaleProject.Dtos.CategoryDtos;
using EstateSaleProject.Dtos.EmployeeDtos;

namespace EstateSaleProject.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployee();
        Task CreateEmployee(CreateEmployeeDto employeeDto);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDto employeeDto);
        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
