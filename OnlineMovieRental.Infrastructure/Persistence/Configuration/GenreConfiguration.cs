using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMovieRental.Domain.Entities;

namespace OnlineMovieRental.Infrastructure.Persistence.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre");
            builder.HasKey(x => x.GenreId);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        }
    }
}
