using EstateSaleProject.Dtos.AppUserDtos;

namespace EstateSaleProject.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
    }
}
