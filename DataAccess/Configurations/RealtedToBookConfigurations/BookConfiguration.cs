using DBCodes.Entities.Concretes.RelatedToBook;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.RealtedToBookConfigurations;

internal class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).UseIdentityColumn();
        builder.Property(b => b.Name).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(b => b.Pages).IsRequired();
        builder.Property(b => b.YearPress).IsRequired();
        builder.Property(b => b.Comment).HasColumnType("nvarchar(50)");
        builder.Property(b => b.Quantity).IsRequired();
    }
}