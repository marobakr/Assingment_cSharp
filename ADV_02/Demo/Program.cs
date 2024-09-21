using System.Collections;
using System.Globalization;

namespace session_2;


class Program
{
 #region Non Generic Collection 
   public static int ArraySum(ArrayList arrayList)
   {
    int Sum = 0;
    if (arrayList is not null)
    {
     for (int i = 0; i < arrayList.Count; i++)
      Sum += (int) arrayList[i]; // Casting From an object [ReferenceType] to int [Value Type] -> Unboxing 
    }
    return Sum;
   }
   #endregion

   #region Generic Collection 
   public static int ArraySumGN(List<int> arrayList)
   {
    int Sum = 0;
    if (arrayList is not null)
    {
     for (int i = 0; i < arrayList.Count; i++)
      Sum += (int) arrayList[i]; 
    }
    return Sum;
   }
   #endregion
    static void Main(string[] args)
    {
        

        #region Non Generic Collection 
        
        ArrayList arrlist = new ArrayList();
        /*
         * count: actual number of elements in array list
         * capacity (Size Of Array): numbers of elements that can be holed
         */
        Console.WriteLine($"count of arraylist= {arrlist.Count} , capacity of arraylist = {arrlist.Capacity}"); // 0 : 0
     
        arrlist.Add(1);
        /*
         * Upon adding the first element to the ArrayList, the capacity is increased to the default capacity (typically 4).
         * Steps after adding the first item in ArrayList:
         * - A new array is created in the heap with a size equal to the default capacity (4).
         * - If the ArrayList had previous items, they are moved to the new array.
         * - The old array, if it existed and is no longer referenced, becomes an unreachable object and is eligible for garbage collection.
         */

        /* add multiple range */
        arrlist.AddRange(new [] {1,2,3,8});
        
        /*
         * When adding a new item to an ArrayList that has reached its capacity:
         * - A new array is created on the heap with double the size of the old array (e.g., from 4 to 8).
         * - Existing elements are copied from the old array to the new array.
         * - The new item is added to the new array.
         */

       /* create an array with  specific size of capacity */
        ArrayList arr = new ArrayList(5) { 1, 2, 3, 5, 8 };
   
        // create a new array at heap with double the size of old array - [10]
        arr.Add(10);
        
        arr.TrimToSize(); // deallocate || free || delete unused bytes
  
        
        /*
         * disadvantage
         *  - Heterogeneous List
         *  - compiler cannot enforce type safety
         */
        arr.Add(2); // casting (1) value type tp object reference type [boxing]
        arr.Add(5); // casting (5) value type tp object reference type [boxing]
        arr.Add("marwan");  //  compiler cannot enforce type safety [data Heterogeneous] 
        
        // ArraySum(new ArrayList() {10,20,30,"marwan",true,"C"}); /* Throw Exception [data Heterogeneous]
        //                                                          * [data Heterogeneous]
        //                                                          */
        #endregion

        #region Generic Collection
        //
        // // List --> arraylist New Version With Generics
        // List <int> num = new List<int>();
        // Console.WriteLine($"count of list = {num.Count} , capacity of list = {num.Capacity}"); // 0
        // num.Add(2);
        // /*
        //  * upon adding the first elements to the list the capacity is increased to _default capacity = 4
        //  * create new array in heap with size = 4
        //  */
        // num.AddRange(new [] {1,5,5,6,5});
        // num.TrimExcess(); // deallocate || free || delete unused bytes
        //
        // /* specified the number of capacity*/
        // List <int> num1 = new List<int>(5){1,2,5,5,45,};
        //
        // for (int i = 0; i < num1.Count; i++)
        // {
        //  Console.WriteLine(num1[i]); // using Indexer To Get Value
        // }
        // num1[2] = 10; // using Indexer To Set Value
        // num1[5] = 10; // You Can't using Indexer To Add Item 
        // ArraySumGN(new List<int>(){10, 20, 30, 50}); // valid 
        #endregion

        #region List Methods

        List<int> listNum = new List<int>(5){ 1, 2, 3, 4,5 };

        #region add one element
           // listNum.Add(4);
        //      // foreach (int item in listNum)
        //      // {
        //      //  Console.WriteLine(item); // 1,2,3,4,5
        //      // }
        #endregion ;

        #region Add Multiple Range Elements
        // listNum.AddRange(new int [] {7,8,9,10});
        // foreach (int item in listNum)
        // {
        //  Console.WriteLine(item); // 1,2,8,7,8
        // }
        #endregion

        #region insert elements in specific Index
        // listNum.Insert(2,10);
        // foreach (int item in listNum)
        //  Console.WriteLine(item); 
        #endregion

        #region insert rang of elements in specific Index
        //
        // listNum.InsertRange(2,new [] {4,4,7,8});
        // foreach (int item in listNum)
        // Console.WriteLine(item); //  1,4,5,4,4,7,8,2, 3,
        #endregion

        #region BinarySearch
        // int index = listNum.BinarySearch(3);
        // Console.WriteLine(index);
        #endregion
       
       // listNum.Clear(); // remove all elements from list 
       
       //
       // listNum.Contains(20); // check if some item exist [boolean]
       //
       // Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
       //

       #region CopyTo
       int[] list = new int [5] ;
       List<int> listArr = new List<int>() { 10, 20, 30 };
       
       // listArr.CopyTo(list);
       // foreach (int item in list)
       // { 
       //  Console.WriteLine(item); // 10 ,20 ,30 ,0 ,0
       // }
       
       
       // listArr.CopyTo(list,2);
       // foreach (int item in list)
       // { 
       //  Console.WriteLine(item); // 0 ,0 ,10 ,20 ,30 
       // }
       //
       
       // Console.WriteLine("===item=="); 

       // listArr.CopyTo(2, list, 1,1);
       // foreach (int item in list)
       // { 
       //  Console.WriteLine(item); // 0 ,0 ,30 ,0 ,0 
       // }

       #endregion

       #region EnsureCapacity

       // Console.WriteLine(listNum.Capacity); // 5
       // listNum.EnsureCapacity(20); // 5 => 10 => 20
       // Console.WriteLine(listNum.Capacity); // 20

       #endregion

       listNum.Reverse();
       Console.WriteLine();
  
       #endregion

        #region Generic Collection - Lists [ LinkedList ]

       // LinkedList<int> linkedList = new LinkedList<int>();
       //
       // linkedList.AddFirst(1);
       // linkedList.AddFirst(2);
       // linkedList.AddLast(3);
       // foreach ( int LinkedList in linkedList)
       // {
       //  Console.WriteLine(LinkedList); // 2 1 3
       // }
       // LinkedListNode<int> nodeAfter = linkedList.Find(2); /* Finds the first node that contains the specified value */
       // linkedList.AddAfter(nodeAfter, 5); /* Adds a new node containing the specified value after the specified existing node */
       //
       // LinkedListNode<int> nodeBefore = linkedList.Find(2); 
       // linkedList.AddBefore(nodeBefore,2); /* Adds a new node containing the specified value before the specified existing node  */

   #endregion

        #region MyRegion

   // Stack<int> stack = new Stack<int>(); /* Represents a variable size last-in-first-out (LIFO) collection of instances of the same specified type. */
   // // Push() /* Inserts an object at the top of the Stack*/
   // stack.Push(1); 
   // stack.Push(2);
   // stack.Push(3);
   // // foreach (int num in stack)
   // // {
   // //  Console.WriteLine(num); // 3 2 1 [LIFO]: Last In First Out 
   // // }
   // // Console.WriteLine(stack.Peek()); // 3 /* Returns the object at the top of the Stack<T> without removing it. */
   // // Console.WriteLine(stack.Pop()); // 3 /* Removes and returns the object at the top of the Stack<T>. */
   //
   // bool re = stack.TryPop(out int Result);
   // Console.WriteLine(re); // true: /* true if there is an object at the top of the Stack<T>; false if the Stack<T> is empty .*/
   // Console.WriteLine(Result); // 3
   #endregion

   #region Queue

   Queue<int> queue = new Queue<int>(); /* Represents a first-in, first-out collection of objects. */
   queue.Enqueue(1); /* Adds an object to the end of the Queue<T>. */
   queue.Enqueue(2);
   queue.Enqueue(3);
   queue.Enqueue(4);

   foreach (int num in queue)
   {
    Console.WriteLine(num); // 1 2 3 4
   }

   queue.Peek();// 1 /* Returns the object at the beginning of the Queue<T> without removing it */
   queue.Dequeue(); // 1 /* Removes and returns the object at the beginning of the Queue<T>.*/
   /*
    * Removes the object at the beginning of the Queue<T>, and copies it to the result parameter.
      Params:
      result – The removed object.
      Returns:
      true if the object is successfully removed; false if the Queue<T> is empty.
    */
   bool result = queue.TryDequeue(out int cout);
   Console.WriteLine(result); // true 
   Console.WriteLine(cout); // 2

   bool res =  queue.TryPeek( out int Cout);
   Console.WriteLine(res); // true 
   Console.WriteLine(Cout); // 3
   #endregion

    }
}


