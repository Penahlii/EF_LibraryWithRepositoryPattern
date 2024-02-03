using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.HumanBeing;

namespace DBCodes.Entities.Concretes.RelatedToLibrary;

public class Department : BaseEntity
{
    public string Name { get; set; }

    // Navigation Properties

    public virtual ICollection<Teacher> Teachers { get; set; }
}