using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Extentions;

namespace RealEstate.Persistence.Configurations
{
    internal class AnnouncementCommentEntityConfiguration : IEntityTypeConfiguration<AnnouncementComment>
    {
        public void Configure(EntityTypeBuilder<AnnouncementComment> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.AnnouncementId).HasColumnType("int").IsRequired();
            builder.Property(m => m.ParentId).HasColumnType("int");
            builder.Property(m => m.Text).HasColumnType("nvarchar(max)").IsRequired();
            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("AnnouncementComments");
        }
    }
}
