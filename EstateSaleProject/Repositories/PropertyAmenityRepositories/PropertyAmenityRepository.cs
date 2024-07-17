using Dapper;
using EstateSaleProject.Dtos.PropertyAmenityDtos;
using EstateSaleProject.Models.DapperContext;
using Microsoft.IdentityModel.Tokens;

namespace EstateSaleProject.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;

        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "select PA.ID, Title from PropertyAmenity PA inner join Amenity A On A.ID=PA.AmenityId where PropertyId=@propertyId and Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection= _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
