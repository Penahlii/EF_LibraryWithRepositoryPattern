using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.HumanBeing;
using DBCodes.Entities.Concretes.RelatedToBook;

namespace DBCodes.Entities.Concretes.Cards;

public class T_Card : BaseEntity
{
    public DateTime DateIn { get; set; }
    public DateTime DateOut { get; set; }


    // Foreign Keys

    public int BookId { get; set; }
    public int TeacherId { get; set; }
    public int LibId { get; set; }

    // Navigation Properties

    public virtual Book Book { get; set; }
    public virtual Teacher Teacher { get; set; }
    public virtual Lib Lib { get; set; }
}