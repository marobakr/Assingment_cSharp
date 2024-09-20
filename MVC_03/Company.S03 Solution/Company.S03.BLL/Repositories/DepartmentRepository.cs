using Company.S03.BLL.Interface;
using Company.S03.DAL.Data.Contexts;
using Company.S03.DAL.Models;

namespace Company.S03.BLL.Repositories;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly AppDbContext _appDbContext;

    public DepartmentRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }


    public IEnumerable<Department> GetAll()
    {
        return _appDbContext.Departments.ToList();
    }

    public Department Get(int id)
    {
        // return _appDbContext.Departments.FirstOrDefault( D => D.Id == id);
        return _appDbContext.Departments.Find(id);
    }


    public int Add(Department entity)
    {
        _appDbContext.Departments.Add(entity);
        return _appDbContext.SaveChanges();
    }


    public int Update(Department entity)
    {
        _appDbContext.Departments.Update(entity);
        return _appDbContext.SaveChanges();
    }

    public int Delete(Department entity)
    {
        _appDbContext.Departments.Remove(entity);
        return _appDbContext.SaveChanges();
    }
}