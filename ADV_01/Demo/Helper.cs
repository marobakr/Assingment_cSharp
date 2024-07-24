namespace session_1;

public class Helper <T>
{
    public static void Swap(ref int x, ref int y)
    {
        int Temp = x;
        x = y;
        y = Temp;
    }
    

    /* Generics Method */
    public static void SwapGn<T>(ref T x, ref T y)
    {
        Console.WriteLine("Swapping");
        T Temp = x;
        x = y;
        y = Temp;
    }
    
    
    /* convert this method To Genarics*/
    public static int SearchArray(int[] arr, int value)
    {
        if (arr is not null)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (value == arr[i])
                {
                    return i;
                }
            }    
        }
        return -1;
    }    
    
    
    //
    // public static int SearchArrayGenracis(T[] arr, T value)
    // {
    //     if (arr is not null)
    //     {
    //         for (int i = 0; i < arr.Length; i++)
    //         {
    //             if (value == arr[i])
    //             {
    //                 return i;
    //             }
    //         }    
    //     }
    //     return -1;
    // }
}
