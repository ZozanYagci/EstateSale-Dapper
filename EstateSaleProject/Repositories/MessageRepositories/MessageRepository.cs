using Dapper;
using EstateSaleProject.Dtos.MessageDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;
        public MessageRepository(Context context)
        {
                    _context = context;
        }
        public async Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id)
        {
           string query= "select top(3) M.ID, Name, Subject, Detail, SendDate, IsRead, ImageUrl " +
                "From Messages M inner join AppUsers A ON M.Sender=A.ID where Receiver=@receiverId order by ID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("receiverId", id);
            using(var connection =_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultInBoxMessageDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
