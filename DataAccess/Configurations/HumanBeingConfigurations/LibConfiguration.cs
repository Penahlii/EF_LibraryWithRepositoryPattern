using DBCodes.Entities.Concretes.HumanBeing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.HumanBeingConfigurations;

internal class LibConfiguration : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Id).UseIdentityColumn();
        builder.Property(l => l.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(l => l.LastName).HasColumnType("nvarchar(25)").IsRequired();
    }
}
