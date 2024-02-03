using DataAccess.Repostories.Abstracts.ICardsRepsitories;
using DBCodes.Entities.Concretes.Cards;

namespace DataAccess.Repostories.Concretes.CardsRepository;

public class T_CardRepository : BaseRepository<T_Card>, IT_CardRepository
{
}
