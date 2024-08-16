namespace session_3;


internal class SortingAlgorithms<T>
{
    #region strategy design pattern
    // public static void BubbleSort(int[] numbers , ICustomComparer comparer)
    // {
    //
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         for (int j = 0; j < numbers.Length - 1 - i; j++)
    //         {
    //             // if (numbers[j] > numbers[j+1])
    //             if (comparer.Compare(numbers[j] , numbers[j + 1]))
    //                 Swap(ref numbers[j], ref numbers[j + 1]);
    //         }
    //     }
    // }
    #endregion
    
    public static void BubbleSort(T[] elements,CustomFunc<T,T,bool> func) 
    {
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length - 1 - i; j++)
            {
                if (func.Invoke(elements[j], elements[j + 1]))
                    Swap(ref elements[j], ref elements[j + 1]);
            }
        }
    }

    private static void Swap(ref T x, ref T y)
    {
        (x, y) = (y, x);
    }
}

