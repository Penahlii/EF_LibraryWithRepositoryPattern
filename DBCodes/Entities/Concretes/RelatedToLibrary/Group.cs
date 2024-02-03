using DBCodes.Entities.Abstracts;
using DBCodes.Entities.Concretes.HumanBeing;

namespace DBCodes.Entities.Concretes.RelatedToLibrary;

public class Group : BaseEntity
{
    public string Name { get; set; }

    // Foreign Keys

    public int FacultyId { get; set; }

    // Navigation Properties

    public virtual ICollection<Student> Students { get; set; }
    public virtual Faculty Faculty { get; set; }
}