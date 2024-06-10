using EstateSaleProject.Dtos.BottomGridDtos;
using EstateSaleProject.Dtos.TestimonialDtos;

namespace EstateSaleProject.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
