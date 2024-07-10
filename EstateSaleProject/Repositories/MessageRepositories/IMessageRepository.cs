using EstateSaleProject.Dtos.MessageDtos;

namespace EstateSaleProject.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
    }
}
