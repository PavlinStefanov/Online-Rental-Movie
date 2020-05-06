using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;
using OnlineMovieRental.Domain.Entities;
using OnlineMovieRental.Infrastructure.Persistence.Configuration;
using OnlineMovieRental.Application.Interfaces;

namespace OnlineMovieRental.Infrastructure.Persistence
{
    public class MovieRentalDbContext : DbContext, IMovieRentalDbContext
    {
        #region Entity Sets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        #endregion

        public MovieRentalDbContext(DbContextOptions<MovieRentalDbContext> options)
            : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new RentalConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());

            base.OnModelCreating(builder);
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public async Task<int> CommitAync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
