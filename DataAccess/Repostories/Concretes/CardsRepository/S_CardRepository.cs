using DataAccess.Repostories.Abstracts.ICardsRepsitories;
using DBCodes.Entities.Concretes.Cards;

namespace DataAccess.Repostories.Concretes.CardsRepository;

public class S_CardRepository : BaseRepository<S_Card>, IS_CardRepository
{
}
