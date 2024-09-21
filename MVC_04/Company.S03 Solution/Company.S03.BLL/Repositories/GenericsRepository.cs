using Company.S03.BLL.Interface;
using Company.S03.DAL.Data.Contexts;
using Company.S03.DAL.Models;

namespace Company.S03.BLL.Repositories;

public class GenericsRepository<T>:IGenericRepository<T> where T:BaseEntity
{
    private readonly AppDbContext _context;

    public GenericsRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public IEnumerable<T> GetAll()
    {
      return  _context.Set<T>().ToList();
    }

    public T Get(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public int Add(T entity)
    {
        _context.Add(entity);
             return _context.SaveChanges();
    }

    public int Update(T entity)
    {
        _context.Update(entity);
        return _context.SaveChanges();    }

    public int Delete(T entity)
    {
        _context.Remove(entity);
        return _context.SaveChanges();    }
}