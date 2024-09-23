using Company.S03.BLL.Interface;
using Company.S03.DAL.Data.Contexts;
using Company.S03.DAL.Models;

namespace Company.S03.BLL.Repositories;

public class DepartmentRepository :GenericsRepository<Department> , IDepartmentRepository
{
    private readonly AppDbContext _appDbContext;

    public DepartmentRepository(AppDbContext appDbContext):base(appDbContext)
    {
    }
    
}