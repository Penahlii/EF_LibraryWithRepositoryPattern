using DBCodes.Entities.Concretes.RelatedToBook;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RealtedToBookConfigurations;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).UseIdentityColumn();
        builder.Property(c => c.Name).HasColumnType("nvarchar(30)").IsRequired();
        builder.HasMany(c => c.Books).WithOne(b => b.Category).HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
