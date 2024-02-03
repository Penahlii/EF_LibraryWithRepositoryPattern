using DBCodes.Entities.Concretes.Cards;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Cardsonfigurations;

internal class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        builder.HasKey(sc => sc.Id);
        builder.Property(sc => sc.Id).UseIdentityColumn();
        builder.HasOne(sc => sc.Student).WithMany(s => s.S_Cards).HasForeignKey(sc => sc.StudentId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(sc => sc.Lib).WithMany(l => l.S_Cards).HasForeignKey(sc => sc.LibId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(sc => sc.Book).WithMany(b => b.S_Cards).HasForeignKey(sc => sc.BookId).OnDelete(DeleteBehavior.Cascade);
    }
}
