using CompanyReader.Domain.Repository.Interfaces;
using CompanyReader.Infrastructure.Persistence;
using CompanyReader.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyReader.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<CompanyReaderDbContext>(options =>
            {
            });

            services.AddScoped<ICompanyRepository, CompanyRepository>();

            return services;
        }
    }
}
