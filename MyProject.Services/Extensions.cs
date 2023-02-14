using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildService, ChildService>();



            services.AddAutoMapper(typeof(Mapping));

            return services;
        }
    }
}
