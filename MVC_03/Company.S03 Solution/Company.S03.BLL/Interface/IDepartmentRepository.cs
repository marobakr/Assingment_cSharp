using System.Net.Sockets;
using Company.S03.DAL.Models;

namespace Company.S03.BLL.Interface;

public interface IDepartmentRepository
{
    /* Signature of the method */
    
    IEnumerable<Department> GetAll();
    Department Get(int id);
   int Add(Department entity);
   int Update(Department entity);
   int Delete(Department entity);
   
}