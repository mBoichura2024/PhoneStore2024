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

namespace UI
{
    public static class UIExtensions
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDatabaseDeveloperPageExceptionFilter();
        }
    }
}
