using DBCodes.Entities.Concretes.HumanBeing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.HumanBeingConfigurations;

internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).UseIdentityColumn();
        builder.Property(t => t.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(t => t.LastName).HasColumnType("nvarchar(25)").IsRequired();
    }
}
