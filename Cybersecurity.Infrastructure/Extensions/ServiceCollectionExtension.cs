using Cybersecurity.Domain.Interfaces;
using Cybersecurity.Infrastructure.Persistence;
using Cybersecurity.Infrastructure.Repositories;
using Cybersecurity.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("Cybersecurity")));

            services.AddScoped<UserSeeder>();

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
