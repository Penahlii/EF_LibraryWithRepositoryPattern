using DataAccess.Repostories.Abstracts.IRelatedToLibraryRepsitories;
using DBCodes.Entities.Concretes.RelatedToLibrary;

namespace DataAccess.Repostories.Concretes.RelatedToLibraryRepository;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
}
