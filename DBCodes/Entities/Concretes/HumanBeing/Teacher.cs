using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.Cards;
using DBCodes.Entities.Concretes.RelatedToLibrary;

namespace DBCodes.Entities.Concretes.HumanBeing;

public class Teacher : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Foreign Keys

    public int DepartmentId { get; set; }

    // Navigation Properties

    public virtual ICollection<T_Card> T_Cards { get; set; }
    public virtual Department Department { get; set; }
}