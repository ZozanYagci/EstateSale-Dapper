
using EstateSaleProject.Models.DapperContext;
using EstateSaleProject.Repositories.BottomGridRepositories;
using EstateSaleProject.Repositories.CategoryRepository;
using EstateSaleProject.Repositories.ContactRepositories;
using EstateSaleProject.Repositories.EmployeeRepositories;
using EstateSaleProject.Repositories.PopularLocationRepositories;
using EstateSaleProject.Repositories.ProductRepository;
using EstateSaleProject.Repositories.ServiceRepository;
using EstateSaleProject.Repositories.StatisticsRepositories;
using EstateSaleProject.Repositories.TestimonialRepositories;
using EstateSaleProject.Repositories.ToDoListRepositories;
using EstateSaleProject.Repositories.WhoWeAreRepository;

namespace EstateSaleProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddTransient<Context>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IWhoWeAreRepository, WhoWeAreDetailRepository>();
            builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
            builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            builder.Services.AddTransient<IContactRepository, ContactRepository>();
            builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
