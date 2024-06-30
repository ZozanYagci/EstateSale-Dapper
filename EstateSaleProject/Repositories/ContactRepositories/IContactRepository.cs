using EstateSaleProject.Dtos.ContactDtos;

namespace EstateSaleProject.Repositories.ContactRepositories
{
    public interface IContactRepository
    {

        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        void CreateContact(CreateContactDto createContactDto);
        void DeleteContact(int id);
        Task<GetByIdContactDto> GetContact(int id);
    }
}
