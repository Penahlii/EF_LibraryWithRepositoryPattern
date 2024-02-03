using DataAccess.Repostories.Abstracts.IRelatedToBookRepsitories;
using DBCodes.Entities.Concretes.RelatedToBook;

namespace DataAccess.Repostories.Concretes.RelatedToBookRepository;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
}
