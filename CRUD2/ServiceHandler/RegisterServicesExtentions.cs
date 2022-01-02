using AutoMapper;
using CRUD2.Interfaces;
using CRUD2.Mapper;
using CRUD2.ServiceHandler.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD2.ServiceHandler
{
    public static class RegisterServicesExtentions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            var mappingConfiguration = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            IMapper mapper = mappingConfiguration.CreateMapper();

            services.AddSingleton(mapper);
            services.AddTransient<IBlogPostService, BlogPostService>();
        }
    }
}
