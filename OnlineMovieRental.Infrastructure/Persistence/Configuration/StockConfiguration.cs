using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMovieRental.Domain.Entities;

namespace OnlineMovieRental.Infrastructure.Persistence.Configuration
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("Stock");
            builder.HasKey(x => x.StockId);
            builder.Property(x => x.MovieId).IsRequired();
            builder.Property(x => x.UniqueKey).IsRequired();
            builder.Property(x => x.IsAvailable).IsRequired();
            builder.HasOne(x => x.Movie)
               .WithMany(x => x.Stocks)
               .HasForeignKey(x => x.MovieId);
        }
    }
}
