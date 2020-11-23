using Microsoft.Extensions.DependencyInjection;
using Northwind.Core.Repository.Constants;
using Northwind.Core.Repository.Helpers;
using Northwind.Core.Repository.Implement;
using Northwind.Core.Repository.Interface;
using Northwind.Core.Services.Implement;
using Northwind.Core.Services.Interface;

namespace Northwind.Core
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IShipperRepository, ShipperRepository>();
            services.AddScoped<IDatabaseConstants, DatabaseConstants>();
            services.AddScoped<IDatabaseHelper, DatabaseHelper>();
            services.AddScoped<IDapperHelper, DapperHelper>();
            services.AddScoped<IShipperService, ShipperService>();
        }
    }
}