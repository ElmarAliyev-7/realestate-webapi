using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Extentions;

namespace RealEstate.Persistence.Configurations
{
    internal class AnnouncementSpecificationValueEntityConfiguration : IEntityTypeConfiguration<AnnouncementSpecificationValue>
    {
        public void Configure(EntityTypeBuilder<AnnouncementSpecificationValue> builder)
        {
            builder.Property(m => m.SpecificationId).HasColumnType("int").IsRequired();
            builder.Property(m => m.AnnouncementId).HasColumnType("int").IsRequired();
            builder.Property(m => m.Value).HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
            builder.ConfigureAuditable();

            builder.HasKey(m => new { m.SpecificationId, m.AnnouncementId });
            builder.ToTable("AnnouncementSpecificationValues");
        }
    }
}
