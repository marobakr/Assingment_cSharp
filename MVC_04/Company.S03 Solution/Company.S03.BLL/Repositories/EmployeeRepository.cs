using Company.S03.BLL.Interface;
using Company.S03.DAL.Data.Contexts;
using Company.S03.DAL.Models;

namespace Company.S03.BLL.Repositories;

public class EmployeeRepository:GenericsRepository<Employee> ,IEmployeeRepositry
{
    public EmployeeRepository(AppDbContext context):base(context)
    {
    }
    
}