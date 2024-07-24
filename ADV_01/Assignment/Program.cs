namespace Assignment;

class Program
{
    static void Main(string[] args)
    {
        #region Ass_01
        // int[] arr = {64, 34, 25, 12, 22, 11, 90};
        // Console.WriteLine("Original array:");
        // BubbleSor.PrintArray(arr);
        //
        // BubbleSor.OptimizedBubbleSort(arr);
        //
        // Console.WriteLine("Sorted array:");
        // BubbleSor.PrintArray(arr);
        #endregion

        #region  Ass_2
        var intRange = new Range<int>(5, 10);
        Console.WriteLine(intRange.IsInRange(7)); 
        Console.WriteLine(intRange.Length());    

        var doubleRange = new Range<double>(3.5, 7.8);
        Console.WriteLine(doubleRange.IsInRange(5.0));
        Console.WriteLine(doubleRange.Length());       

        #endregion
        
    }
}