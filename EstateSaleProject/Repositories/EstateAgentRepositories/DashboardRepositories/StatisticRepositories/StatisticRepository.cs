using Dapper;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;
        public StatisticRepository(Context context)
        {
            _context = context;
        }
        public int AllProductCount()
        {
            string query = " Select Count(*) From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCountByEmployeeId(int id)
        {
            string query = " Select Count(*) From Product where EmployeeID=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public int ProductCountByStatusFalse(int id)
        {
            string query = "Select Count(*) From Product Where EmployeeID=@employeeId and Status=0";
            var parameters = new DynamicParameters();
            parameters.Add("employeeId", id);
            using( var connection = _context.CreateConnection())
            {
                var values=connection.QueryFirstOrDefault<int>(query,parameters);
                return values;
            }
        }

        public int ProductCountByStatusTrue(int id)
        {
            string query = "Select Count(*) From Product Where EmployeeID=@employeeId and Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }
    }
}
