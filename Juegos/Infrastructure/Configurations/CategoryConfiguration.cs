using Juegos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Juegos.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.ToTable("Categories");

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.Property(x => x.Name)
               .HasMaxLength(30);

            builder.OwnsMany(x => x.Details, builder =>
            {
                builder.ToTable("CategoryDetails");

                builder.HasIndex(x => new { x.CategoryId, x.Code }).IsUnique();

                builder.Property(x => x.Code)
                    .HasMaxLength(50);

                builder.Property(x => x.Title)
                    .HasMaxLength(100);

                builder.Property(x => x.Image)
                    .HasMaxLength(500);

                builder.Property(x => x.AbandonComments)
                    .HasMaxLength(500);

            });
        }
    }
}
