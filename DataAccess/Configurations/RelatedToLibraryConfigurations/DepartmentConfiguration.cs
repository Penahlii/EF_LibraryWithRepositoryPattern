using DBCodes.Entities.Concretes.RelatedToLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RelatedToLibraryConfigurations;

internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Id).UseIdentityColumn();
        builder.Property(d => d.Name).HasColumnType("nvarchar(40)").IsRequired();
        builder.HasMany(d => d.Teachers).WithOne(t => t.Department).HasForeignKey(t => t.DepartmentId).OnDelete(DeleteBehavior.Cascade);
    }
}