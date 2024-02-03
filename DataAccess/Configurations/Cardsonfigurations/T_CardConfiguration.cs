using DBCodes.Entities.Concretes.Cards;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Cardsonfigurations;

internal class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        builder.HasKey(tc => tc.Id);
        builder.Property(tc => tc.Id).UseIdentityColumn();
        builder.HasOne(tc => tc.Book).WithMany(b => b.T_Cards).HasForeignKey(tc => tc.BookId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(tc => tc.Teacher).WithMany(t => t.T_Cards).HasForeignKey(tc => tc.TeacherId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(tc => tc.Lib).WithMany(l => l.T_Cards).HasForeignKey(tc => tc.LibId).OnDelete(DeleteBehavior.Cascade);
    }
}