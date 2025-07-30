using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Extentions;

namespace RealEstate.Persistence.Configurations
{
    internal class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Cities");
        }
    }
}
