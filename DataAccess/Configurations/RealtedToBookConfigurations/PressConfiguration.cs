using DBCodes.Entities.Concretes.RelatedToBook;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RealtedToBookConfigurations;

internal class PressConfiguration : IEntityTypeConfiguration<Press>
{
    public void Configure(EntityTypeBuilder<Press> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.Property(p => p.Name).HasColumnType("nvarchar(30)").IsRequired();
        builder.HasMany(p => p.Books).WithOne(b => b.Press).HasForeignKey(b => b.PressId).OnDelete(DeleteBehavior.Cascade);
    }
}
