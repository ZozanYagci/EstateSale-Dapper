using Dapper;
using EstateSaleProject.Dtos.CategoryDtos;
using EstateSaleProject.Dtos.WhoWeAreDetailDtos;
using EstateSaleProject.Dtos.WhoWeAreDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.WhoWeAreRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreRepository
    {
        private readonly Context _context;
        public WhoWeAreDetailRepository(Context context)
        {
                _context = context;
        }
        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail(Title, SubTitle, Description1, Description2) values (@title, @subTitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDto.Title);
            parameters.Add("@subTitle", createWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDto.Description2);
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {

            string query = "delete from WhoWeAreDetail where ID=@whoWeAreID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
        {

            string query = "select*from WhoWeAreDetail where ID=@whoWeAreId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail Set Title=@title, SubTitle=@subTitle, Description1=@description1, Description2=@description2 where ID=@whoWeAreId";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@subTitle", updateWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDto.Description2);
            parameters.Add("@whoWeAreId", updateWhoWeAreDetailDto.ID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
