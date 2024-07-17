﻿using Dapper;
using EstateSaleProject.Dtos.ContactDtos;
using EstateSaleProject.Models.DapperContext;


namespace EstateSaleProject.Repositories.ContactRepositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;
        public ContactRepository(Context context)
        {
                _context = context;
        }
        public Task CreateContact(CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllContact()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdContactDto> GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDto>> GetLast4Contact()
        {
            string query = "Select Top(4) * From Contact Order By ID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
            
        }
    }
}
