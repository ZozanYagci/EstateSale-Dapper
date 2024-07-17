using EstateSaleProject.Dtos.SubFeatureDtos;

namespace EstateSaleProject.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
