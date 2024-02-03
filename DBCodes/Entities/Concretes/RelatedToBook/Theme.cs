using DBCodes.Entities.Abstracts;

namespace DBCodes.Entities.Concretes.RelatedToBook;

public class Theme : BaseEntity
{
    public string Name { get; set; }

    // Navigation Properties

    public virtual ICollection<Book> Books { get; set; }
}