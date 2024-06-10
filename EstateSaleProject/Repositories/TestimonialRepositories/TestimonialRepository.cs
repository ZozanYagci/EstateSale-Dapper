using Dapper;
using EstateSaleProject.Dtos.TestimonialDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;
        public TestimonialRepository(Context context)
        {
                _context=context;
        }
        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "select *from Testimonial";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }
    }
}
