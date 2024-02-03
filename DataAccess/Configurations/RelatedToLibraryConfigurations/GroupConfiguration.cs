using DBCodes.Entities.Concretes.RelatedToLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RelatedToLibraryConfigurations;

internal class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id);
        builder.Property(g => g.Id).UseIdentityColumn();
        builder.Property(g => g.Name).HasColumnType("nvarchar(10)").IsRequired();
        builder.HasIndex(g => g.Name).IsUnique();
        builder.HasMany(g => g.Students).WithOne(s => s.Group).HasForeignKey(s => s.GroupId).OnDelete(DeleteBehavior.Cascade);
    }
}
