using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMovieRental.Domain.Entities;

namespace OnlineMovieRental.Infrastructure.Persistence.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
			builder.ToTable("Customer");
			builder.HasKey(x => x.CustomerId);
			builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
			builder.Property(x => x.LastName).HasMaxLength(100).IsRequired();
			builder.Property(x => x.IdentityCard).HasMaxLength(50).IsRequired();
			builder.Property(x => x.Mobile).HasMaxLength(10).IsRequired();
			builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
			builder.Property(x => x.DateOfBirth).IsRequired();
		}
    }
}
