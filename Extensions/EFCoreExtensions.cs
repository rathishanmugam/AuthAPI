﻿using AuthApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Extensions
{
    public static class EFCoreExtensions
    {
        public static IServiceCollection InjectDbContext(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(config.GetConnectionString("WebApiDatabase")));
            return services;
        }
    }
}