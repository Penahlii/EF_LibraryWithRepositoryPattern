using DBCodes.Entities.Concretes.RelatedToLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RelatedToLibraryConfigurations;

internal class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id).UseIdentityColumn();
        builder.Property(f => f.Name).HasColumnType("nvarchar(20)").IsRequired();
        builder.HasMany(f => f.Groups).WithOne(g => g.Faculty).HasForeignKey(g => g.FacultyId).OnDelete(DeleteBehavior.Cascade);
    }
}
