using System.Collections;

namespace Assignment;

class Program
{
    #region Implements Ass_01[Part02]

    public static void Revere(ref ArrayList arrayList)
    {
        if (arrayList is not null)
        {
            int count = arrayList.Count;

            for (int i = 0; i < count / 2 ; i++)
            {
                (arrayList[i], arrayList[count - i - 1]) = (arrayList[count - i - 1], arrayList[i]);
            }
        }
    }    

    #endregion
    
    #region Implements Ass_02[Part02]

    public static List<int> GetEven(List<int> listNumber) 
    {
        List<int> EvenList = new List<int>();
        for (int i = 0; i < listNumber.Count; i++)
        {
            if (listNumber[i]  % 2 == 0)
                EvenList.Add(listNumber[i]);               
        }

        return EvenList;
    } 
    
    #endregion
    
    static void Main(string[] args)
    {
        /* ============================== Part 01 ==============================*/
        /* This task Will be Allocated to Demo Project */

        /* ============================== Part 02 ==============================*/

        #region Ass_01
        // ArrayList arrayList = new ArrayList()
        // {
        //     10, 20, 30, 40
        // };
        // foreach ( int num in  arrayList)
        // {
        //     Console.WriteLine(num);
        // }
        //
        // Console.WriteLine("Before Reverse");
        // revere(ref arrayList);
        // foreach ( int num in  arrayList)
        // {
        //     Console.WriteLine(num);
        // }
        #endregion

        #region Ass_02
       //
       //  List<int> listNumber = new List<int>()
       //  {
       //      1, 4, 5, 8, 10, 15, 20
       //  };
       //
       // List<int> EventNumber = GetEven(listNumber);
       //
       // foreach (int num in EventNumber)
       // {
       //     Console.WriteLine(num);
       // }
        #endregion

        #region Ass_03

        FixedSizeList<int> gnArr = new FixedSizeList<int>(5);
        gnArr.Add(10);
        gnArr.Add(11);
        gnArr.Add(12);
        gnArr.Add(13);
        gnArr.Add(14);
        Console.WriteLine(gnArr.Get(2));

        #endregion

    }
}