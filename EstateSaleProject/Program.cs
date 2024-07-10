
using EstateSaleProject.Hubs;
using EstateSaleProject.Models.DapperContext;
using EstateSaleProject.Repositories.BottomGridRepositories;
using EstateSaleProject.Repositories.CategoryRepository;
using EstateSaleProject.Repositories.ContactRepositories;
using EstateSaleProject.Repositories.EmployeeRepositories;
using EstateSaleProject.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using EstateSaleProject.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using EstateSaleProject.Repositories.LastProductsRepositories;
using EstateSaleProject.Repositories.MessageRepositories;
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
            builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
            builder.Services.AddTransient<IChartRepository, ChartRepository>(); 
            builder.Services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            builder.Services.AddTransient<IMessageRepository, MessageRepository>();

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .SetIsOriginAllowed((host) => true)
                           .AllowCredentials();
                });
            });
            builder.Services.AddHttpClient();
            builder.Services.AddSignalR();

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

            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.MapHub<SignalRHub>("/signalrhub");
            //localhost:1234/swagger/category/
            //localhost:1234/signalrhub

            app.Run();
        }
    }
}
