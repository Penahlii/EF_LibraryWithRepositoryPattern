using DBCodes.Entities.Concretes.HumanBeing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.HumanBeingConfigurations;

internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).UseIdentityColumn();
        builder.Property(a => a.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(a => a.LastName).HasColumnType("nvarchar(25)").IsRequired();
        builder.HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
    }
}
