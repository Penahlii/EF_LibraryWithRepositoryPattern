using DBCodes.Entities.Abstracts;

namespace DataAccess.Repostories.Abstracts;

public interface IBaseRepository<T> where T : BaseEntity, new()
{
    ICollection<T> GetAll();
    T? GetById(int Id);
    void Add(T entity);
    void Save();
    void Remove(T entity);
    void Update(T entity);
}