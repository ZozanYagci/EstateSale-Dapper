using EstateSaleProject.Dtos.ContactDtos;

namespace EstateSaleProject.Repositories.ContactRepositories
{
    public interface IContactRepository
    {

        Task<List<ResultContactDto>> GetAllContact();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        Task CreateContact(CreateContactDto createContactDto);
        Task DeleteContact(int id);
        Task<GetByIdContactDto> GetContact(int id);
    }
}
