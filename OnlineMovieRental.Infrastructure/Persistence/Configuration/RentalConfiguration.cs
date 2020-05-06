using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMovieRental.Domain.Entities;

namespace OnlineMovieRental.Infrastructure.Persistence.Configuration
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rental");
            builder.HasKey(x => x.RentalId);
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.StockId).IsRequired();
            builder.Property(x => x.ReturnedDate).IsRequired(required: false);
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Rentals)
                .HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Stock)
               .WithMany(x => x.Rentals)
               .HasForeignKey(x => x.StockId);
        }
    }
}
