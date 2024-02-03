using DBCodes.Entities.Concretes.RelatedToBook;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RealtedToBookConfigurations;

internal class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).UseIdentityColumn();
        builder.Property(t => t.Name).HasColumnType("nvarchar(30)").IsRequired();
        builder.HasMany(t => t.Books).WithOne(b => b.Theme).HasForeignKey(b => b.ThemeId);
    }
}
