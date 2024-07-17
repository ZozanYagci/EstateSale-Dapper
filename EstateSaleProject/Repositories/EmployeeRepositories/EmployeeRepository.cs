using Dapper;
using EstateSaleProject.Dtos.EmployeeDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;
        public EmployeeRepository(Context context)
        {
                _context = context;
        }
        public async Task CreateEmployee(CreateEmployeeDto employeeDto)
        {
            string query = "insert into Employee(Name, Title, Mail, PhoneNumber, ImageUrl, Status) values(@name, @title, @email, @phoneNumber, @imageUrl, @status)";

            var parameters = new DynamicParameters();
            parameters.Add("@name", employeeDto.Name);
            parameters.Add("@title", employeeDto.Title);
            parameters.Add("@email", employeeDto.Mail);
            parameters.Add("@phoneNumber", employeeDto.PhoneNumber);
            parameters.Add("@imageUrl", employeeDto.ImageUrl);
            parameters.Add("@status", true);
           using(var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters); 
            }
        }

        public async Task DeleteEmployee(int id)
        {
            string query = "Delete From Employee where ID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using(var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployee()
        {
            string query = "Select * From Employee";
            using(var connection = _context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdEmployeeDto> GetEmployee(int id)
        {
            string query = "Select * From Employee where ID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdEmployeeDto>(query, parameters);
                return values;
            }
        }


        public async Task UpdateEmployee(UpdateEmployeeDto employeeDto)
        {
            string query = "Update Employee Set Name=@name, Title=@title, Mail=@email, PhoneNumber=@phoneNumber, ImageUrl=@imageUrl, Status=@status where ID=@employeeID";


            var parameters = new DynamicParameters();
            parameters.Add("@name", employeeDto.Name);
            parameters.Add("@title", employeeDto.Title);
            parameters.Add("@email", employeeDto.Mail);
            parameters.Add("@phoneNumber", employeeDto.PhoneNumber);
            parameters.Add("@imageUrl", employeeDto.ImageUrl);
            parameters.Add("@status", employeeDto.Status);
            parameters.Add("@employeeID", employeeDto.ID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }


        }
    }
}
