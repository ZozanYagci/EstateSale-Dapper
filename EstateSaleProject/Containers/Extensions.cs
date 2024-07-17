using EstateSaleProject.Models.DapperContext;
using EstateSaleProject.Repositories.AppUserRepositories;
using EstateSaleProject.Repositories.BottomGridRepositories;
using EstateSaleProject.Repositories.CategoryRepository;
using EstateSaleProject.Repositories.ContactRepositories;
using EstateSaleProject.Repositories.EmployeeRepositories;
using EstateSaleProject.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using EstateSaleProject.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using EstateSaleProject.Repositories.LastProductsRepositories;
using EstateSaleProject.Repositories.MessageRepositories;
using EstateSaleProject.Repositories.PopularLocationRepositories;
using EstateSaleProject.Repositories.ProductImageRepositories;
using EstateSaleProject.Repositories.ProductRepository;
using EstateSaleProject.Repositories.PropertyAmenityRepositories;
using EstateSaleProject.Repositories.ServiceRepository;
using EstateSaleProject.Repositories.StatisticsRepositories;
using EstateSaleProject.Repositories.SubFeatureRepositories;
using EstateSaleProject.Repositories.TestimonialRepositories;
using EstateSaleProject.Repositories.ToDoListRepositories;
using EstateSaleProject.Repositories.WhoWeAreRepository;

namespace EstateSaleProject.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();

        }
    }
}
