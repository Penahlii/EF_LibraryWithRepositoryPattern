#nullable disable

using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.Cards;
using DBCodes.Entities.Concretes.HumanBeing;

namespace DBCodes.Entities.Concretes.RelatedToBook;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    public string? Comment { get; set; }
    public int Quantity { get; set; }


    // Foreign Keys

    public int ThemeId { get; set; }
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int PressId { get; set; }

    // Navigation Properties

    public virtual Theme Theme { get; set; } 
    public virtual Author Author { get; set; }
    public virtual ICollection<T_Card> T_Cards  { get; set; }
    public virtual ICollection<S_Card> S_Cards { get; set; }
    public virtual Category Category { get; set; }
    public virtual Press Press { get; set; }
}