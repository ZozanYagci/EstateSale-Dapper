using Dapper;
using EstateSaleProject.Dtos.ProductDtos;
using EstateSaleProject.Models.DapperContext;

namespace EstateSaleProject.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            string query = "insert into Product(Title, Price, City, District, CoverImage, Address, Description, Type," +
                " DealOfTheDay, AdvertisementDate, Status, ProductCategory, EmployeeID)" +
                " values (@title, @price, @city, @district, @coverImage, @address, @description," +
                "@type, @dealOfTheDay, @advertisementDate, @status, @productCategory, @employeeID)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createProductDto.Title);
            parameters.Add("@price", createProductDto.Price);
            parameters.Add("@city", createProductDto.City);
            parameters.Add("@district", createProductDto.District);
            parameters.Add("@coverImage", createProductDto.CoverImage);
            parameters.Add("@address", createProductDto.Address);
            parameters.Add("@description", createProductDto.Description);
            parameters.Add("@type", createProductDto.Type);
            parameters.Add("@dealOfTheDay", createProductDto.DealOfTheDay);
            parameters.Add("@advertisementDate", createProductDto.AdvertisementDate);
            parameters.Add("@status", createProductDto.Status);
            parameters.Add("@productCategory", createProductDto.ProductCategory);
            parameters.Add("@employeeID", createProductDto.EmployeeID);
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "select *from Product";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select Product.ID, Title, Price, City, District, Name, CoverImage, Type, Address, DealOfTheDay From Product inner join Category on Product.ProductCategory=Category.ID";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync()
        {
            string query = "Select Top(5) P.ID, Title, Price, City, District, ProductCategory, AdvertisementDate" +
                " From Product P inner join Category C on P.ProductCategory=C.ID Where Type='Kiralık' Order By P.ID Desc";
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultLast5ProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByFalse(int id)
        {
            string query = "Select Product.ID, Title, Price, City, District, Name, CoverImage, Type, Address, DealOfTheDay From Product inner join " +
             "Category C on Product.ProductCategory=C.ID where EmployeeID=@employeeId And Product.Status=0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByTrue(int id)
        {
            string query = "Select Product.ID, Title, Price, City, District, Name, CoverImage, Type, Address, DealOfTheDay From Product inner join " +
              "Category C on Product.ProductCategory=C.ID where EmployeeID=@employeeId And Product.Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connections = _context.CreateConnection())
            {
                var values = await connections.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay = 0 where ID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay = 1 where ID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
