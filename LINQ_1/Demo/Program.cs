namespace session_1;

class Program
{
    static void Main(string[] args)
    {
        #region Implicitly Type Local Variables

        #region Var
        /*
         * var: is a c# Keyword [c# 3.0 feature]
         * var: is a c# keyword that is used to declare a variable without specifying its type.
         * var: is a keyword that tells the compiler to infer the type of the variable from the expression on the right side of the initialization statement.
         * Compiler can detect the type of the variable based on the initial value [at compilation time].
         * must be Initialized at the time of declaration
         * can't be initialized with null
         * after initialization you can't change the type of the variable
         * safe code because the compiler checks the type of the variable at compile time.  
         */

        var x = 10;
            x = 40; // valid
        //  x = "Hello"; /* invalid: throw an error in run Compilation time */; 
        var z = new { Name = "Ahmed", Age = 25 }; // Anonymous Type 
        // Console.WriteLine(z.salary) // invalid: throw an error in run Compilation time;
        #endregion
        
        #region Dynamic
        /*
         * Dynamic: is a c# Keyword [C# 4.0 Feature]
         * is a keyword that tells the compiler to defer the type of the variable until runtime.
         * Compiler doesn't check the type of the variable at compile time.
         * Compiler will Escape the type checking at compile time.
         * The CLR is resolved at runtime.
         * Dynamic is a type that can be used to store any type of value.
         * Not Must be initialized at the time of declaration
         * After initialization you can change the type of the variable
         * unsafe code because the compiler doesn't check the type of the variable at compile time.
         */

        dynamic y;
                y = "Hello";
                y = true;
                // y = null; /* throw an error in run time */
                
                dynamic a = new { Name = "Ahmed", Age = 25 }; // Anonymous Type 
                // Console.WriteLine(a.salary); // valid: throw an error in run time;

                #endregion
                
        #endregion

        #region Anonymouse Type Obejct Is Immutable Type Object

        /*
         * Anonymous Type: is a c# Feature [C# 3.0 Feature]
         * is a type that doesn't have a name.
         * is a class that is created by the compiler.
         * The Object That Will be created from Anonymous Type is Read-Only. [IS an Immutable Object] 
         */
        var employee1 = new { Name = "Ahmed", Id = 1, Salary = 1000 }; 
        var employee2 = new { Name = "Ahmed", Id = 1, Salary = 1000 }; 
        Console.WriteLine(employee1.GetType().Name);  /*  '<>f__AnonymousType[1: number of anonymous type] [`3': number of property]*/
        Console.WriteLine(employee2.GetType().Name);  /*  '<>f__AnonymousType[1: number of anonymous type] [`3': number of property]*/
        // employee2.Id = 10; // invalid
        /* TO change must crate New Object */
        employee2 = new { Name = "Mona", employee2.Id, employee2.Salary }; // valid [Syntax Sugar
        
        /* Or */        
        employee2 = employee2 with{ Name = "Mona", }; // valid

        var employee3 = new { Id = 1, Salary = 1000,Name = "Ahmed" }; 
        Console.WriteLine(employee3.GetType().Name);  /*  '<>f__AnonymousType[2: number of anonymous type] [`3': number of property]*/
        

        /*
         * The Same AnonymousType Desn't create New Class  as long as:
         * 1. The Same Properties Naming [Case Sensitive]
         * 2. The Same Properties Order
         */
        
        #endregion

        #region Extention Method

        int  v = 1235;
        
        int reversedNumber = v.Reverse(); /* v: this */
        Console.WriteLine(reversedNumber);

        #endregion

        #region What is LINQ
    
        /*
         * LINQ: Language Integrated Query
         * LINQ: +40 Extension Methods for IEnumerable Interface
         * is a c# feature that is used to query data from different data sources.
         *     :Names as "LINQ Operators" Extension in CLass "Enumerable";
         *     : Categories into 13 Categories
         * Use LINQ Opreators againts data, regardless data (Store in Sequence) . (File,database ...)
         * Sequence: is an object that implements IEnumerable<T> interface like List , HashSet, Array, Dictionary, ...
         * Sequence is
         *  - Local Sequence: L2O (LINQ to Object) not TO SQL  | L2XML | L2JSON (Static Data)
         *  - Remote Sequence: L2EF (LINQ to Entity) TO SQL (Dynamic Data)
         */
        
        
        /*
         * What is (ORM) Object Relational Mapping?
         * is a programming technique that is used to map the object-oriented domain model to a relational database.
         * is a technique that is used to convert the data between incompatible type systems in object-oriented programming languages.
         */
        
        List<int> NUMbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};

        /* Desired Execution */
        // List<int> Odds = NUMbers.Where((N) => N % 2 == 1).ToList();
        // NUMbers.AddRange(new [] {1, 2, 3, 4, 5, 6, 7, 8}); // not effect on Odds

        Console.WriteLine("**************");
        
        /* Immediate Execution */
        var Odds = NUMbers.Where((N) => N % 2 == 1);
        NUMbers.AddRange(new [] {11,12,13,14,15}); // Effect on Odds
        
        foreach (var num in Odds)
        {
            Console.WriteLine(num); // 1,3,5,7,9,11,13,15
        }
        #endregion

        #region LINQ Syntax 
        
        #region 01- Fluent Syntax
        List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        
        /* 1.1 Call "LINQ Operators" as => Static Methods Throw "Enumerable" Class*/
        var odds = Enumerable.Where<int>(numbers, (N) => N % 2 == 1);
        
        /* 1.2 Call "LINQ Operator" as => Extensions Method  */
        var odds1 = numbers.Where((N) => N % 2 == 1);
        #endregion

        #region Query Syntax : Query Expression  ( Like SQLServer Style )

        /*
         * Select N
         * From numbers N
         *  Where N % 2 == 1
         */
        
        /*
         * Query Expression
         * 1. Must Start with "From" Keyword
         * Introducing Range Variable (N): is a variable that is used to represent each element in the sequence.
         * 2. Must End with "Select Or Groube By" Keyword
         */
        List<int> numbersOdds = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        
       var numberResult = from N in numbersOdds
            where N % 2 == 1
            select N;

        #endregion
        
        #endregion

        #region LINQ Execution Ways

        #region Differed Execution
            // List<int> Nums = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            // var result = Nums.Where((N) => N % 2 == 1); // Differed Execution
            // Nums.AddRange(new[] {11, 12, 13, 14, 15}); // Effect on result
            // foreach (var num in Nums)
            // {
            //     Console.WriteLine(num); // 1,3,5,7,9,11,13,15 
            // }
            #endregion
        
        #region Immediate Execution (Element Operatorsm, Casting Operators, Aggregation Operators)
        List<int> Nums = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            
            var result = Nums.Where((N) => N % 2 == 1).ToList(); // Differed Execution
            Nums.AddRange(new[] {11, 12, 13, 14, 15}); // Effect on a result
            
            foreach (var num in Nums)
            {
                Console.WriteLine(num); // 1,3,5,7,9
            }
        #endregion

        #endregion
        
        #region LINQ Operators

        Console.WriteLine(ListGenerator.ProductList[0]);
        Console.WriteLine(ListGenerator.CustomerList[0]);
        #endregion
        
    }
}

static class IntExtentions
{
    /*
     * This: is a keyword that is used to pass the current object to the method.
     * 
     */
    public static int Reverse(this int number)
    {
        int ReversedNumber = 0;
        int remainder;
        while (number > 0)
        {
            remainder = number % 10;
            ReversedNumber = ReversedNumber * 10 + remainder;
            number = number / 10;  // this step to remove the last digit from the number
        }
        return ReversedNumber; 
    }
}

