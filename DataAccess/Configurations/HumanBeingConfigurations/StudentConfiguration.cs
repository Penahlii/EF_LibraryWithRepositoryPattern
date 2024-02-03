using DBCodes.Entities.Concretes.HumanBeing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.HumanBeingConfigurations;

internal class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).UseIdentityColumn();
        builder.Property(s => s.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(s => s.LastName).HasColumnType("nvarchar(25)").IsRequired();
        builder.Property(s => s.Term).IsRequired();
    }
}
