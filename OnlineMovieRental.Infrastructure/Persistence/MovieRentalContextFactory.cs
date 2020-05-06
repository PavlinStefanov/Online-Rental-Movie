using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace OnlineMovieRental.Infrastructure.Persistence
{
    class MovieRentalContextFactory : IDesignTimeDbContextFactory<MovieRentalDbContext>
    {
        public MovieRentalDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieRentalDbContext>();
            optionsBuilder.UseSqlServer("data source=.;initial catalog=MovieRentalDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

            return new MovieRentalDbContext(optionsBuilder.Options);
        }
    }
}
