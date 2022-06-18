using DemoCQRS.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DemoCQRS.MediatRDal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediatRDal(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("database"));
            
            var thisAssembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(thisAssembly);
            services.AddAutoMapper(thisAssembly);
            
            return services;
        }
    }
}
