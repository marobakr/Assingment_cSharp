namespace Company.S03.BLL.Interface;

public interface IGenericRepository<T>
{
    IEnumerable<T> GetAll();
    T Get(int id);
    int Add(T entity);
    int Update(T entity);
    int Delete(T entity);
}