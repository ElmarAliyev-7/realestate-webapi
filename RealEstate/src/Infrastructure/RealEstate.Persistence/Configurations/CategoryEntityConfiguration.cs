using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Extentions;

namespace RealEstate.Persistence.Configurations
{
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(m => m.ImagePath).HasColumnType("nvarchar").HasMaxLength(500);
            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Categories");
        }
    }
}
