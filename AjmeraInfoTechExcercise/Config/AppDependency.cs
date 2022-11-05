using AITExcercise.DA;
using AITExcercise.DA.Interface;
using AITExcercise.Service;
using AITExcercise.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjmeraInfoTechExcercise.API.Config
{
    public class AppDependency
    {
        public static void Map(IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookDA, BookDA>();
            services.AddMemoryCache();
        }
    }
}
