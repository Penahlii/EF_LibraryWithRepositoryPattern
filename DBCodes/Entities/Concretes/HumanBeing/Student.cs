using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.Cards;
using DBCodes.Entities.Concretes.RelatedToLibrary;

namespace DBCodes.Entities.Concretes.HumanBeing;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Term { get; set; }


    // Foreign Keys

    public int GroupId { get; set; }

    // Navigation Properties

    public virtual ICollection<S_Card> S_Cards { get; set; }
    public virtual Group Group { get; set; }
}