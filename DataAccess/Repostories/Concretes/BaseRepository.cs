using DataAccess.Contexts;
using DataAccess.Repostories.Abstracts;
using DBCodes.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repostories.Concretes;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
{
    internal readonly EFLibrary _context;
    internal readonly DbSet<T> _table;

    public BaseRepository()
    {
        _context = new EFLibrary();
        _table = _context.Set<T>();
    }


    public void Add(T entity)
    {
        if (entity is null) throw new ArgumentNullException("NULL");
        _table.Add(entity);
    }

    public ICollection<T> GetAll()
    {
        return _table.ToList();
    }

    public T? GetById(int Id)
    {
        if (Id <= 0) throw new ArgumentException("Id is INVALID");
        return _context?.Set<T>().FirstOrDefault(a => a.Id == Id);
    }

    public void Remove(T entity)
    {
        if (entity is null) throw new ArgumentNullException("NULL");
        var ent = _context?.Set<T>().FirstOrDefault(e => e.Id == entity.Id);
        if (ent is null) throw new ArgumentNullException("NULL");
        _context?.Set<T>().Remove(ent);
    }

    public void Save()
    {
        _context?.SaveChanges();
    }

    public void Update(T entity)
    {
        if (entity is null) throw new ArgumentNullException("NULL");
        _context?.Set<T>().Update(entity);
    }
}