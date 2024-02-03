using DBCodes.Entities.Abstracts;

namespace DBCodes.Entities.Concretes.RelatedToLibrary;

public class Faculty : BaseEntity
{
    public string Name { get; set; }

    // Navigation Properties

    public virtual ICollection<Group> Groups { get; set; }
}