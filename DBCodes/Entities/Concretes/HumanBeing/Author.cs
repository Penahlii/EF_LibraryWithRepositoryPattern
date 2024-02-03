using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.RelatedToBook;

namespace DBCodes.Entities.Concretes.HumanBeing;

public class Author : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Properties

    public virtual ICollection<Book> Books { get; set; }
}