using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Core
{
    public static class CoreExtensions
    {
        public static void AddCustomServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
        public static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppProfiles));
        }
    }
}
