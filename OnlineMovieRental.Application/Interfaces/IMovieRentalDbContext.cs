using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineMovieRental.Domain.Entities;

namespace OnlineMovieRental.Application.Interfaces
{
    public interface IMovieRentalDbContext
    {
        #region Entity Sets
        public DbSet<Domain.Entities.Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        #endregion

        void Commit();
        Task<int> CommitAync(CancellationToken cancellationToken);
    }
}
