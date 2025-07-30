using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;

namespace RealEstate.Persistence.Configurations
{
    internal class AnnouncementSpecificationEntityConfiguration : IEntityTypeConfiguration<AnnouncementSpecification>
    {
        public void Configure(EntityTypeBuilder<AnnouncementSpecification> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(250).IsRequired();
            builder.Property(m => m.IsActive).HasColumnType("bit").IsRequired();

            builder.HasKey(m => m.Id);
            builder.ToTable("AnnouncementSpecifications");
        }
    }
}
