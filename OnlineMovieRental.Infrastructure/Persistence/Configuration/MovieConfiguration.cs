using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMovieRental.Domain.Entities;

namespace OnlineMovieRental.Infrastructure.Persistence.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(x => x.MovieId);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.GenreId).IsRequired();
            builder.Property(x => x.Director).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Writer).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Producer).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(2000).IsRequired();
            builder.Property(x => x.TrailerURI).HasMaxLength(200);
            builder.HasOne(x => x.Genre)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.GenreId);
        }
    }
}
