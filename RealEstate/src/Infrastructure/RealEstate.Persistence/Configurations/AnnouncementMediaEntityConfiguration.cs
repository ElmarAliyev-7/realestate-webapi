using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Extentions;

namespace RealEstate.Persistence.Configurations
{
    internal class AnnouncementMediaEntityConfiguration : IEntityTypeConfiguration<AnnouncementMedia>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AnnouncementMedia> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.AnnouncementId).HasColumnType("int").IsRequired();
            builder.Property(m => m.Path).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(m => m.IsMain).HasColumnType("bit").IsRequired();
            builder.Property(m => m.Type).HasColumnType("int").IsRequired();
            builder.ConfigureAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("AnnouncementMedias");

            builder.HasOne<Announcement>()
                .WithMany()
                .HasForeignKey(m => m.AnnouncementId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
