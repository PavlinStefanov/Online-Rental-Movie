using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OnlineMovieRental.Infrastructure.Persistence;
using OnlineMovieRental.Application.Interfaces;

namespace OnlineMovieRental.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            //services.AddDbContext<MovieRentalDbContext>(options => options.UseInMemoryDatabase(databaseName: "MovieRentalDb"));

            // Dependencies for MSSQL Server
            IConfigurationRoot _settingsBuilder = ConfigurationSettingsBuilder.GetSettingsFile();
            var connection = _settingsBuilder["ConnectionStrings:OnlineMovieRentalConnectionString"];
            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<MovieRentalDbContext>(options => options.UseSqlServer(connection));
            services.AddTransient<IMovieRentalDbContext, MovieRentalDbContext>();

            return services;
        }
    }
}
