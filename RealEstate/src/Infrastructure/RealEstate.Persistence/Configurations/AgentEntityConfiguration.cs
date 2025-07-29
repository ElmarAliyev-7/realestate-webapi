using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain.Entities;

namespace RealEstate.Persistence.Configurations
{
    internal class AgentEntityConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.Surname).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(m => m.Email).HasColumnType("varchar").HasMaxLength(70).IsRequired();
            builder.Property(m => m.Phone).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            builder.HasKey(m => m.Id);
            builder.ToTable("Agents");
        }
    }
}
