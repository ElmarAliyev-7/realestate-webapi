using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Extentions;

namespace RealEstate.Persistence.Configurations
{
    internal class BlogPostLikeEntityConfiguration : IEntityTypeConfiguration<BlogPostLike>
    {
        public void Configure(EntityTypeBuilder<BlogPostLike> builder)
        {
            builder.Property(m => m.BlogPostId).HasColumnType("int").IsRequired();
            builder.ConfigureAuditable();

            builder.HasKey(m => new { m.BlogPostId, m.CreatedBy });
            builder.ToTable("BlogPostLikes");

            builder.HasOne<BlogPost>()
                .WithMany()
                .HasForeignKey(m => m.BlogPostId)
                .HasPrincipalKey(m => m.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
