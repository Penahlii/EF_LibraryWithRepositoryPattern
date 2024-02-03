using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.Cards;

namespace DBCodes.Entities.Concretes.HumanBeing;

public class Lib : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Properties

    public virtual ICollection<T_Card> T_Cards { get; set; }
    public virtual ICollection<S_Card> S_Cards { get; set; }
}