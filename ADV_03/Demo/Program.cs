namespace session_3;

#region Step 0 Delegate Declaration

/*
 * Step 0 Delegate Declaration
 * New Delegate Convert to the (Class), the reference form this delegate can refer to a function or more [Pointer to Function]
 * these functions can be class member [static] or object member [non-static]
 * these functions must have the same signature of this delegate
 * Regardless function access modifier
 */
#endregion

/* Delegate 01*/
public delegate int CustomFunc(string arr);

/* Delegate 02 */
public delegate bool CustomFunc<T>(T x, T y);

/* Generics Delegate 03 */
/*
 * in act Input
 * out act Output
 */
public delegate TResult CustomFunc<in T1,in T2, out TResult>(T1 x, T2 y);

/* Delegate 04 */

// public delegate bool CustomPredicate<in T>(T number);

class Program
{
    // public static List<T> FindElements<T>(List<T>? Element,Func<T,bool> func)
    
    public static List<T> FindElements<T>(List<T>? Element,Predicate<T> func)

    // public static List<T> FindElements<T>(List<T> Element,CustomPredicate<T> func) 
    {
         List<T> result = new List<T>();
         if (Element is not null)
         {
             foreach (var num in Element)
             {
                 if (func.Invoke(num)) 
                     result.Add(num);
             }
         }
         return result;
    }
    
    static void Main(string[] args)
    {
        #region Delegate Intro
        /*
         * Delegate is A C# Language Feature [C# 2.0]
         * Delegate in Compilation convert to Class
         * Has 2 Usages:
         *  - Function Programming:
         *      - store function to variables
         *      - Function returns a function
         *      -
         *  - Event-Driven Programming 
         */
        /*
         * reference form class can refer to an object
         * reference form delegate can refer to and function
         */

        /* Step 1. Declare Delegate Reference*/
        // CustomFunc referenceDelegate;
        //
        // /* Step 2. Initialize the Delegate Reference [Pointer To Function] */
        // // referenceDelegate = new CustomFunc(StringFunctions.GetCountOfUpperCaseChar);
        //
        // referenceDelegate = StringFunctions.GetCountOfUpperCaseChar; /* Syntax Sugar*/
        //
        // /* The Last Function it will be invoked  */
        // referenceDelegate += StringFunctions.GetCountOfLowerCaseChar; /* add multiple reference Function*/
        //
        // referenceDelegate -= StringFunctions.GetCountOfUpperCaseChar; /* remove this reference Function from delegate */
        //
        //
        // #region Like Sem String
        // string x = "str";
        // x = new string("str");
        //
        // #endregion
        //
        // /* Step 3. Use The Delegate Reference */
        // // referenceDelegate.Invoke("marwan ABUBAKR"); 
        //
        // int result =  referenceDelegate("marwan ABUBAKR"); /* Syntax Sugar */
        // Console.WriteLine(result); // 6

        #endregion

        #region Strategy design pattern
        // int[] arr =  { 1,5,7,9,6,2, };

        /* Sort Asc*/
        // SortingAlgorithms.BubbleSort(arr,new AscComparer());
        
        /* Sort Desc*/
        // SortingAlgorithms.BubbleSort(arr,new DescComparer());
        // foreach (int num in arr)
        // {
        //     Console.WriteLine(num);
        // }
        #endregion
        
        #region Exam_1
        int[] arr =  { 1,5,7,9,6,2, };

        // 01 - CustomFunc<int> fnc = new CustomFunc<int>(SortingTypes.CompaerGtr);
        // 02 - CustomFunc<int> fnc = (SortingTypes.CompaerGtr);
        // 03 - Pass function directly SortingAlgorithms.BubbleSort(arr, SortingTypes.CompaerGtr);
       
        // CustomFunc<int,int,bool> fnc = (SortingTypes.CompaerGtr);
        // SortingAlgorithms<int>.BubbleSort(arr, fnc);
        //
        // foreach (int item in arr)
        // {
        //     Console.WriteLine(item);
        // }
        #endregion

        #region Exam_2
        //
        // string[] Name = { "ziad", "ahmed", "mohamed", "mostafa" };
        // SortingAlgorithms<string>.BubbleSort(Name,SortingTypes.CompaerLes);
        #endregion

        #region Exam_3
        List<int> number = Enumerable.Range(1, 10).ToList();

        #region Find Odd
        /* Use Custom Predicate*/
        
        // CustomPredicate<int> predicate = CondationFnc.IsOdd;
        // List<int> resultIsOdd =  FindElements(number,predicate);

        /* Use Built-in Predicate*/
        Predicate<int> predicate = CondationFnc.IsOdd;
        List<int> resultIsOdd =  FindElements(number,predicate);


        foreach (int num in resultIsOdd)
        {
            Console.WriteLine(num); 
        }
        #endregion
        
        Console.WriteLine("*******************");
        
        #region Find Even

        /* Use Built-in Predicate*/
        Predicate<int> predicate2 = CondationFnc.IsEven;
        List<int> resultIsEven =  FindElements(number,predicate2);
        
        /* Use Custom Predicate*/
        // CustomPredicate<int> predicate2 = CondationFnc.IsEven;
        // List<int> resultIsEven =  FindElements(number,predicate2);

        foreach (int num in resultIsEven)
        {
            Console.WriteLine(num); 
        }
        #endregion

        #region GetLength

        List<string> names = new List<string>() {"Ahm","Mon","Tor","Julia","Antonio","saiedd"};

        /* Use Built-in Predicate*/
        Predicate<string> predicate02 = CondationFnc.IsLengthEqual;
        List<string> findNamesMoreThanFive = FindElements<string>(names,predicate02);

        /* Use built-in Func */
        // Func<string,bool> predicate02 = CondationFnc.IsLengthEqual;
        
        /* Use Custom Predicate*/
        // CustomPredicate<string> predicate02 = CondationFnc.IsLengthEqual;
        // List<string> findNamesMoreThanFive = FindElements<string>(names,predicate02);        

        foreach (string name in findNamesMoreThanFive)
        {
            Console.WriteLine(name);
        }

        #endregion

        #endregion

        #region Built-in Delegate
        /*
         * We have 3 Built-in Delegate
         *  - Predicate -> can refer to function have parameter and must have return bool
         *  - Fnc -> can refer to function have 0 or 16 parameters and must have any return
         *  - Action -> can refer to function have 0 or 16 parameters and must be void
         * so we can spare the step numb 0 [Delegate Declaration]
         */

        #region predicate
        // Predicate<int> predicate03;
        // // predicate03 = new Predicate<int>(SomeFunction.Test);
        // predicate03 = (SomeFunction.Test); // Syntax Sugar
        //
        // // predicate03.Invoke(10);
        // predicate03(10); // Syntax Sugar

        #endregion

        #region Func

        // Func<int, string> func = SomeFunction.Cast;
        // func.Invoke(10);


        #endregion

        #region Action
        // Action action = SomeFunction.Print;
        // action.Invoke();
        #endregion

        #region ActionGn
        // Action<string> ActionGn = SomeFunction.PrintGn;
        // ActionGn.Invoke("marwan");
        #endregion
        
        #endregion

        #region Anonymous Function c# 2.0 feature (.NET Framework 2.0)[2005]

        #region predicate
        //
        // Predicate<int> predicate03;
        //
        // predicate03 = delegate(int number) { return number > 0; };
        // predicate03(10); // Syntax Sugar

        #endregion

        #region Func
        // Func<int, string> func = delegate(int number) { return number.ToString();};
        // func.Invoke(10);


        #endregion

        #region Action
        // Action action = delegate { Console.WriteLine("Hello World!");} ;
        // action.Invoke();
        #endregion

        #region ActionGn
        //
        // Action<string> ActionGn = delegate(string name) { Console.WriteLine($"Hello World {name}"); };
        //
        // ActionGn.Invoke("marwan");
        #endregion

        #endregion
        
        #region Lambda Expresstion c# 3.0 feature (.NET Framework 3.0)[2007]

        #region predicate
        Predicate<int> predicate03;
        predicate03 = (int number) => number > 0;
        predicate03(10); // Syntax Sugar

        #endregion

        #region Func
        Func<int, string> func = number => number.ToString(); // lumbeda 
        func.Invoke(10);
        #endregion

        #region Action
        Action action =  () => Console.WriteLine("Hello World!"); ;
        action.Invoke();
        
        #endregion
        #region ActionGn
        Action<string> ActionGn = name  => Console.WriteLine($"Hello World {name}");
        ActionGn.Invoke("marwan");
        #endregion

        #endregion

        #region Var 

        // var Keyword -> Implicitly Typed Local Variables [C# 2.0]
        var x = 10; // valid
        // x = "str"; // invalid 
        
        var predicat1 = (int number) => number > 0;
        predicat1(10); // Syntax Sugar
        
        var func1 = (int number) => number.ToString(); // lumbeda 
        func.Invoke(10);
        
        var action1 =  () => Console.WriteLine("Hello World!"); ;
        action.Invoke();

        #endregion


    }
}

class StringFunctions
{
    public static int GetCountOfUpperCaseChar(string? name)
    {
        Console.WriteLine("GetCountOfUpperCaseChar");
        int count = 0;
        if (name is not null)
            for (int i = 0; i < name.Length; i++)
                if (char.IsUpper(name[i]))
                    count++;
        return count;
    }
    public static int GetCountOfLowerCaseChar(string? name)
    {
        Console.WriteLine("GetCountOfLowerCaseChar");

        int count = 0;
        if (name is not null)
            for (int i = 0; i < name.Length; i++)
                if (char.IsLower(name[i]))
                    count++;
        return count;
    }


}

class CondationFnc
{
    public static bool IsOdd(int number) => number % 2 == 1;
    public static bool IsEven(int number) => number % 2 != 1;
    public static bool IsLengthEqual(string name) => name.Length > 4;

}

class SortingTypes
{
    #region Exam_1
    // public static bool CompaerGtr(int x, int y) => x > y; // Sort Asc
    // public static bool CompaerLes (int x , int y) => x<y; // Sort Desc
    #endregion

    #region Exam 2

    public static bool CompaerGtr(string x, string y) => x.CompareTo(y) ==1 ; // Sort Asc
    public static bool CompaerLes (string x , string y) => x.CompareTo(y)  == -1; // Sort Desc

    #endregion
   

}

class SomeFunction
{
    public static bool Test(int number) => number > 0;
    public static string Cast(int number) => number.ToString();
    
    public static void Print () => Console.WriteLine("Hello World!");
    public static void PrintGn (string name ) => Console.WriteLine($"Hello World {name}");
    
}



// متنساش حتته + - 



