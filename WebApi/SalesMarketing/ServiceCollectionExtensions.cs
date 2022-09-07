using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace WebApi.SalesMarketing
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesMarketing(this IServiceCollection services, string connectionString)
        {
            //var assembly = AppDomain.CurrentDomain.Load("Data");
            //services.AddMediatR(assembly);
            //  services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<SalesMarketingContext>(options =>
              options.UseSqlServer(connectionString));

            services.AddMediatR(Assembly.GetExecutingAssembly());
          //  services.AddTransient<ICommandsScheduler, CommandsScheduler>();

          //  services.AddScoped<ISalesMarketingEventBus, SalesMarketingEventBus>();

          //  services.AddHostedService<SalesMarketingInternalCommandsWorker>();
          //  services.AddHostedService<SalesMarketingOutBoxWorker>();


            return services;
        }
    }
}
