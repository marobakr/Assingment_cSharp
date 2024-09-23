using Company.S03.BLL.Interface;
using Company.S03.DAL.Data.Contexts;
using Company.S03.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.S03.BLL.Repositories;

public class EmployeeRepository:GenericsRepository<Employee> ,IEmployeeRepositry
{
    public EmployeeRepository(AppDbContext context):base(context)
    {
         
    }

    public IEnumerable<Employee> GetByName(string name)
    {
     return   _context.Employees.Where(E => E.Name.ToLower().Contains(name.ToLower())).Include(E =>E.WorkFor).ToList();
    }
}