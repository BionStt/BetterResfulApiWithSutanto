using AuditLogging.Data.Context;
using AuditLogging.Services.Contract;
using AuditLogging.Services.Implementation;
using AuditLogging.Services.Repository.Contract;
using AuditLogging.Services.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuditLogStorage(this IServiceCollection services, string connectionString)
        {
            //  services.AddTransient<IDbConnection>(_ => new SqlConnection(connectionString));
            services.AddScoped<IAudit, Audit>();
            services.AddScoped<IAuditLogRepository, AuditLogRepository>();
            services.AddDbContext<AuditLogContext>(options =>
               options.UseSqlServer(connectionString, sqlOptions =>
               {
                   sqlOptions.EnableRetryOnFailure(
                       3,
                       TimeSpan.FromSeconds(300),
                       null);
               }));

            // services.BuildServiceProvider().GetService<AuditContext>().Database.Migrate();

            return services;

        }
    }
}
