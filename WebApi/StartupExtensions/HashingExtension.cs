﻿//using Microsoft.AspNetCore.Identity;

//namespace WebApi.StartupExtensions
//{
//    public static class HashExtension
//    {
//        public static IServiceCollection AddCustomizedHash(this IServiceCollection services, IConfiguration configuration)
//        {
//            services.Configure<HashingOptions>(configuration.GetSection(HashingOptions.Hashing));
//            services.AddScoped<IPasswordHasher, PasswordHasher>();

//            return services;
//        }
//    }
//}