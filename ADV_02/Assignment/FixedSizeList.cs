using System.Collections;
/*============================== Implements Ass_03[Part02] ==============================*/
namespace Assignment;

public class FixedSizeList<T> 
{
    #region Ass_3.1

    private int Capacity = default;
    private int count = 0;  
    public T[] array;

    public FixedSizeList(int capacity)
    {
        Capacity = capacity;
        array = new T[capacity];
    }


    #endregion
 
    #region Ass_3.2

    public void Add(T item)
    {
        if(count > Capacity )
            throw new InvalidOperationException("Cannot add more elements.");
        array[count] = item;
        ++count;
    }

    #endregion

    #region Ass_3.3

    public T Get(int i)
    {
        return array[i];
    }

    #endregion
  
  
}