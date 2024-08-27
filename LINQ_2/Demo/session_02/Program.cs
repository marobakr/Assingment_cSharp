using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace session_02;

using static ListGenerator;

class Program
{
    static void Main(string[] args)
    {
        #region Deferred execution

        // Filtration Operators (Where)  
        // Filters a collection based on a specified condition.
        // Examples include filtering products with UnitsInStock == 0 and UnitsInStock == 0 && Category == "Seafood".
        // Transformation Operators (Select, SelectMany)  
        // Select: Projects each element of a collection into a new form.
        // SelectMany: Projects each element of a collection to an IEnumerable<T> and flattens the resulting sequences into one sequence.
        // Examples include selecting product names, creating anonymous types, and flattening customer orders.
        // Ordering Operators (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)  
        // OrderBy: Sorts the elements of a sequence in ascending order.
        // OrderByDescending: Sorts the elements of a sequence in descending order.
        // ThenBy: Performs a subsequent ordering of the elements in ascending order.
        // ThenByDescending: Performs a subsequent ordering of the elements in descending order.
        // Reverse: Reverses the order of the elements in a sequence.
        // Examples include ordering products by UnitPrice and ProductID.

        #region Filtration Operators (Restriction Operators Where )

        /*
         * The `Where` operator filters a collection based on a specified condition.
         * It returns a new collection containing only the elements that meet the condition.
         * The operator takes a lambda expression as its parameter. In this case, the lambda expression is:
         * (predicate) => predicate.UnitsInStock == 0
         * This lambda expression defines the filtering condition, where `predicate` represents each item in the `ProductList` collection.
         * `predicate` is a placeholder for each individual element of the collection during iteration.
         */

        #region Example 01

        // /* Fluent Syntax*/

        // Func<Product, bool> func = (p) => p.UnitsInStock == 0;
        // var Result = ListGenerator.ProductList.Where(func);

        /* Or */
        // var Result = ListGenerator.ProductList.Where((predicate) => predicate.UnitsInStock == 0);

        // /* SQL Syntax */
        // Result = from P in ListGenerator.ProductList
        //     where P.UnitsInStock == 0
        //     select P;  

        #endregion

        #region Example 02

        /*
         * 01 Overload [Where]
         */

        /* Fluent Syntax*/
        // var Result = ListGenerator.ProductList.Where((p) => p.UnitsInStock == 0 && p.Category == " Seafood" );
        //
        // /* SQL Syntax */
        // Result = from P in ListGenerator.ProductList
        //     where P.UnitsInStock == 0 && P.Category == " Seafood"
        //     select P;

        /*
         * 02 Overload [Indexed Where]
         * The `Where` operator has an overload that takes an additional parameter, `index`, which represents the index of the element in the collection.
         * This overload is useful when you need to filter elements based on their index in the collection.
         * Valid Only With Fluent Syntax . Can't be used with SQL Syntax
         */
        // Result = ListGenerator.ProductList.Where((p,index)=> index < 10 && p.UnitsInStock == 0);
        // foreach (var item in Result)
        // {
        // Console.WriteLine(item);
        // }

        #endregion

        #region TypeOf!!!!!!!!!!

        #endregion

        #endregion

        #region Transformation Operators (Projection Operators) Select | SelectMany |

        #region Select

        /*
         * 01 Overload [Select]
         * The `Select` operator projects each element of a collection into a new form.
         * It takes a lambda expression as its parameter, which defines the transformation to be applied to each element.
         * The lambda expression is: (p) => p.ProductName
         * This lambda expression defines the transformation, where `p` represents each item in the `ProductList` collection.
         */

        #region Example 01

        // /* Fluent Syntax*/
        // var result = ListGenerator.ProductList.Select(((p) => p.ProductName));
        //
        // /* Sql Syntax*/
        // result = from P in ListGenerator.ProductList
        //     select P.ProductName;
        //

        #endregion

        #region Example 02

        // var result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0)
        //     .Select(p => $"{p.ProductID} - {p.ProductName}");
        //
        // result = from p in ListGenerator.ProductList
        //     where p.UnitsInStock > 0
        //     select $"{p.ProductID} - {p.ProductName}";

        #endregion

        #region Example 03

        /* Fluent Syntax */
        // var result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0)
        //  .Select(p => new { ProductID = p.ProductID,ProductName = p.ProductName }); // Create Anonymous Type
        //  // .Select(p => new {  p.ProductID, p.ProductName }); // Create Anonymous Type + Retrieve Data | Without Property Name because its the same as the property name
        //
        //
        //  /* Sql Syntax */
        // result = from p in ListGenerator.ProductList
        //  where p.UnitsInStock > 0
        //  select new { ProductID = p.ProductID,ProductName = p.ProductName }; // Create Anonymous Type + Retrieve Data
        //

        #endregion

        #region Example 04

        /*
         *  Step 0: Filtration
         *  Step 1: Select
         */

        /* Fluent Syntax */
        // var result = ProductList.Where(p => p.UnitPrice >0)
        //                                                .Select(p=> new
        //                                                {
        //                                                 p.ProductID, p.ProductName, NewPrice = p.UnitPrice * 2
        //                                                });
        // /* Sql Syntax */
        //
        // result = from p in ProductList
        //  where p.UnitsInStock > 0
        //  select new
        //  {
        //   p.ProductID, 
        //   p.ProductName, 
        //   NewPrice = p.UnitPrice * 2
        //  };

        #endregion

        /*
         * 02 Overload [Select]
         * The `Select` operator has an overload that takes an additional parameter, `index`, which represents the index of the element in the collection.
         * This overload is useful when you need to project elements based on their index in the collection.
         * Valid Only With Fluent Syntax, Can't be used with SQL Syntax
         */

        #region Indexed Select

        /*
         * indexed Select Valid only with Fluent Syntax
         */
        // var result = ProductList.Select((p, index) => new
        // {
        //  index = index,
        //  pName = p.ProductName
        // });

        #endregion

        #endregion

        #region SelectMany

        #region 01 Overload

        /*
         * SelectMany
         * The `SelectMany` operator projects each element of a collection to an `IEnumerable<T>`, and then flattens the resulting sequences into one sequence.
         * It is useful when you have a collection of collections and you want to flatten it into a single collection.
         * The operator takes a lambda expression as its parameter, which defines the transformation to be applied to each element.
         * The lambda expression is: (C) => C.Orders
         * This lambda expression defines the transformation, where `C` represents each item in the `CustomerList` collection.
         * `C.Orders` is a collection of orders for each customer, and `SelectMany` flattens these collections into a single sequence of orders.
         * The result is a collection of orders from all customers.
         * must return Property of type IEnumerable<T>
         */

        /* Fluent Syntax */
        // var Result1  = CustomerList.SelectMany(C => C.Orders);
        //
        // /* SQL Syntax */
        // Result1 = from C in CustomerList
        //  from O in C.Orders
        //  select O;
        //
        // foreach (var item in Result1)
        // {
        //  Console.WriteLine(item);
        // }

        #endregion

        #region 02 Overload

        /* Fluent Syntax */
        /*
         * Return a Specific Property
         */
        var Result1 = CustomerList.SelectMany(C => C.Orders, ((customer, order) => new { customer, order }));

        /* SQL Syntax */
        Result1 = from C in CustomerList
            from O in C.Orders
            select new { customer = C, order = O };

        foreach (var item in Result1)
        {
            Console.WriteLine(item);
        }

        #endregion

        #endregion

        #endregion

        #region Ordering Operators (Sorting Operators) OrderBy | OrderByDescending | ThenBy | ThenByDescending | Reverse

        /*
         * 01 Overload OrderBy()
         * Must Implements IComparable
         */
        // var Result = ProductList.Order();
        // var Result = ProductList.OrderDescending();

        /* Fluent Syntax */

        //OrderBy
        // var Result = ProductList.OrderBy((p) => p.UnitPrice);
        //
        // //OrderByDescending
        //  Result = ProductList.OrderByDescending((p) => p.UnitPrice);
        //  
        //  //ThenBy
        //  Result = ProductList.OrderByDescending((p) => p.UnitPrice).ThenBy((p) => p.ProductID);
        //
        //  //ThenByDescending
        //  Result = ProductList.OrderByDescending((p) => p.UnitPrice).ThenByDescending((p) => p.ProductID);
        //
        //  //Reverse /* Not Available in Query Expression  */
        //  var sResultRevers = ProductList.Where((p) => p.UnitPrice == 0).Reverse();
        //
        //  
        // /* SQL Syntax */
        //
        // // OrderBy
        // Result = from p in ProductList
        //  orderby p.UnitPrice
        //  select p;
        //
        // // OrderByDescending
        // Result = from p in ProductList 
        //  orderby p.UnitPrice descending 
        //  select p;
        //
        // // ThenBy
        // Result = from p in ProductList
        //  orderby p.UnitPrice , p.ProductName 
        //  select p;
        //
        // // ThenByDescending
        // Result = from p in ProductList
        //  orderby p.UnitPrice, p.ProductName  descending 
        //  select p;
        //

        #endregion

        #endregion

        #region Element Operators -  Immediate Execution

        /* Element Operators: are valid only with Fluent Syntax */

        #region First & Last

        /*
         * [First & Last ]: If the collection is empty, an exception is thrown.
         */
        // ProductList = new List<Product>();
        // var Result  = ProductList.First();// Return the first element in the collection in case the sequence contains just only one element 
        // Result = ProductList.Last(); // Return the last element in the collection in case the sequence contains just only one element 
        //

        #endregion

        #region FirstOrDefault & LastOrDefault

        /*
         * [FirstOrDefault & LastOrDefault ]: If the collection is empty ? the default value for the element type is returned.
         */
        // var  Result  = ProductList.FirstOrDefault();// Return the first element in the collection 
        //   Result = ProductList.LastOrDefault(); // Return the last element in the collection
        //   Console.WriteLine(Result?.ProductName ?? "not found"); // not found


        /*
         * [FirstOrDefault(default) & LastOrDefault(default) ]: If the collection is empty ? Return specific value.
         */
        //
        // ProductList = new List<Product>();
        // Result  = ProductList.FirstOrDefault(new Product() {ProductName = "ahemd "});
        // Result = ProductList.LastOrDefault(); 

        #endregion

        #region first(predict) | Last(predict) | FirstOrDefault(predict, Default) | LastOrDefault(predict, Default)

        /*
         * Returns the [first(predict) OR Last(predict)] element in a sequence that satisfies a specified condition.
         */
        //
        // var result = ProductList.First((p) => p.UnitPrice > 0);
        //  result = ProductList.Last((p) => p.UnitPrice > 0);

        /*
         * Returns the [FirstOrDefault(predict, Default) OR LastOrDefault(predict, Default)] element in a sequence that satisfies a specified condition, or a default value if no such element is found.
         */
        // result = ProductList.LastOrDefault((p) => p.UnitPrice > 0, new Product() {ProductName = "ahemd "});
        // result = ProductList.FirstOrDefault((p) => p.UnitPrice > 0, new Product() {ProductName = "ahemd "});
        //

        #endregion

        #region ElementAt() | ElementAtOrDefault()

        /*
         * ElementAt: Returns the element at a specified index in a sequence.
         * if the index is out of range, an exception is thrown.
         * ElementAtOrDefault: Returns the element at a specified index in a sequence or a default value if the index is out of range.

         *
         */
        // var Result = ProductList.ElementAt(10);// Return the 10th element in the collection
        //     Result = ProductList.ElementAt(new Index(10, fromEnd: true)); // Return the 10th element from the end of the collection
        //     

        //     Result = ProductList.ElementAtOrDefault(10);// 
        //     Result = ProductList.ElementAtOrDefault(new Index(10, fromEnd: true));
        //     Console.WriteLine(Result?.ProductName ?? "not found");
        //
        //     

        #endregion

        #region Single | Single(Predicat) SingleOrDefault | SingleOrDefault(Predicat) | SingleOrDefault(Predicat,Defualt)

        /*
         * Single: Returns the only element of a sequence If Sequence is Contains Only One Element, and throws an exception if more than one such element exists.
         * If the collection has zero or more than one element, it will throw an exception.
         */
        // var Result = ProductList.Single();// Return the only element in the collection


        /*
         * Returns the only element of a sequence if Elements Match the condition
         * If no elements satisfy the condition, Throw Exception.
         * If more than one element satisfies the condition, Throw Exception
         */
        // Result = ProductList.Single(p => p.ProductID == 1);// Return the element in the collection with ProductID == 1


        /*
         * If Sequence Empty? Return Default Value For Type "Product"
         * If Sequence Contains Only One Element? Return The Element
         * If Sequence Contains More Than One Element? Throw Exception
         */
        // Result = ProductList.SingleOrDefault();// Return the only element in the collection
        //
        //
        // /*
        //  * Returns the only element of a sequence if Elements Match the condition
        //  * If no elements satisfy the condition, the default value for the type TSource is returned.
        //  * If more than one element satisfies the condition, an exception is thrown.
        //  */
        // Result = ProductList.SingleOrDefault(p => p.ProductID == 1);// Return the element in the collection with ProductID == 1
        //
        // /*
        //  * Returns the only element of a sequence if Elements Match the condition
        //  * If no elements satisfy the condition, Return the specified Default Value
        //  * If more than one element satisfies the condition, an exception is thrown.
        //  */
        // Result = ProductList.SingleOrDefault(p => p.ProductID == 1,new Product(){ProductName = "name pro"});
        //
        //
        // /*
        //  * If Sequence Empty? Return The Specified Default Value
        //  * If Sequence Contains Only One Element? Return The Element
        //  * If Sequence Contains More Than One Element? Throw Exception
        //  */
        // Result = ProductList.SingleOrDefault(new Product() {ProductName = "ahemd "}); // Return the default value if the collection is empty
        //
        // Console.WriteLine(Result?.ProductName ?? "not found"); ;

        #endregion

        #endregion

        #region Aggregation Operators -  Immediate Execution

        #region Count() Count(Predicate)

        /*
         * The built-in property `Count` is used for collections that implement ICollection<T>
         * while the LINQ method `Count()` can be used on any IEnumerable<T>
         * The `Count` property is more efficient than the `Count()` method because it does not require iterating over the entire collection.
         */
        // var Result = ProductList.Count(); // Return the number of elements in the collection
        // Result = ProductList.Count; 

        /*
         * Returns the number of elements in the collection that satisfy the condition.
         * The `Count` method has an overload that takes a predicate as a parameter.
         */
        // Result = ProductList.Count(p => p.ProductID == 78);

        #endregion

        #region TryGetNonEnumeratedCount [.NET 6.0]

        /*
         * TryGetNonEnumeratedCount: Returns the number of elements in the collection without enumerating it.
         * This method is useful when the collection implements ICollection<T> and has a `Count` property.
         * It returns `true` if the count can be determined without enumeration, and `false` otherwise.
         * The count is stored in the `out` parameter `count`.
         */
        // int count;
        // bool result = ProductList.Where(p => p.ProductID == 1).TryGetNonEnumeratedCount(out count);
        // if (result)
        // {
        //  Console.WriteLine($"Count: {count}");
        // }
        // else
        // {
        //  Console.WriteLine("Count could not be determined without enumeration.");
        // }

        #endregion

        #region Sum(Func) | Average(Func)

        /*
         * The `Sum` method calculates the sum of the numeric values in a collection.
         * It returns the sum of the elements in the collection.
         * The `Sum` method has an overload that takes a predicate as a parameter.
         * have 10 overloads that accept different types of arguments.
         */
        // var Result  = ProductList.Sum(p => p.UnitPrice); // Return the sum of the UnitPrice values in the collection
        //    Result  = ProductList.Average(p => p.UnitPrice); // Return the average of the UnitPrice values in the collection

        #endregion

        #region Min() | Max()|  Min(FUNC) | Max(FUNC) | MinBy(Func) | MaxBy(Func) [.NET 6.0 Feature]

        /*
         * The `Min` method returns the minimum value in a collection.
         * The `Max` method returns the maximum value in a collection.
         * Must Implement IComparable
         */
        // var MaxProduct = ProductList.Max(); // Return the maximum value in the collection
        // var MinmumProduct = ProductList.Max(); // Return the Minmum value in the collection

        /*
         * The `Max` method returns the element with the maximum value in a collection Based on Property.
         * The `Min` method returns the element with the minimum value in a collection Based on Property.
         */
        // var MaxBy = ProductList.Max(p => p.ProductName); 
        // var MinBy = ProductList.Min(p => p.ProductName);


        /*
         * The `MaxBy` method returns the element with the maximum value in a collection Based on Property.
         * The `MinBy` method returns the element with the minimum value in a collection Based on Property.
         */
        // var MaxBy = ProductList.MaxBy(p => p.ProductID); 
        // var MinBy = ProductList.MinBy(p => p.UnitPrice);


        /*
         * The `MaxBy` method has an overload that takes a comparer as a parameter.
         * The `MinBy` method has an overload that takes a comparer as a parameter.
         * The comparer specifies the comparison logic.
         */
        // MaxBy = ProductList.MaxBy(p => p.ProductID, Comparer<long>.Default); 
        // MinBy = ProductList.MinBy(p => p.UnitPrice, Comparer<decimal>.Default); 

        #endregion

        #region Aggregate(Func) | Aggregate(seed, Func)

        /*
         * The `Aggregate` Like is Reduce in Js
         * The `Aggregate` method performs a custom aggregation operation on the elements of a collection.
         * Applies an accumulator function over a sequence.
         * The first overload uses the first element of the sequence as the initial accumulator value.
         * The second overload takes an initial seed value and applies the accumulator function starting from that seed.
         */
        // string[] Names = { "ahmed", "mohamed", "ali" };
        //
        // string FullName = Names.Aggregate((a, b) => $"{a} , {b}"); // ahmed , mohamed , ali
        // FullName = Names.Aggregate("marwan", (a, b) => $"{a} , {b}"); // marwan , ahmed, mohamed, ali
        // FullName = Names.Aggregate("marwan",
        //     (a, b) => $"{a} , {b}, {"hello"}"); // marwan , ahmed, hello , mohamed, hello , ali, hello

        #endregion

        #region Conversion (Csting) Operators - Immediate Execution

        // List<Product> Result = ProductList.Where(p => p.UnitsInStock == 0)
        //  .ToList();
        //
        // Product[] ResultArray = ProductList.Where(p => p.UnitsInStock == 0)
        //  .ToArray();
        //
        // /* 01 Overlaid */
        // Dictionary<long, Product> dictionary1 = ProductList.Where(p => p.UnitsInStock == 0)
        //  .ToDictionary(p => p.ProductID);
        //
        // /* 02 Overlaid */
        // Dictionary<long, string> dictionary2 = ProductList.Where(p => p.UnitsInStock == 0)
        //  .ToDictionary(p => p.ProductID,p => p.ProductName);
        //
        // /* 03 Overlaid */
        // HashSet<Product> hashSet = ProductList.Where(p => p.UnitsInStock == 0)
        //  .ToHashSet();
        //
        // /*
        //  * ToLookup: Creates a Lookup<TKey, TElement> from an IEnumerable<T> according to a specified key selector function.
        //  * The `ToLookup` method is similar to the `ToDictionary` method, but it returns a Lookup<TKey, TElement> instead of a Dictionary<TKey, TElement>.
        //  */
        //
        // /* 04 Overlaid */
        // ILookup<long, Product> lookup = ProductList.Where(p => p.UnitsInStock == 0)
        //  .ToLookup(p => p.ProductID);

        // foreach (var item in Result)
        // {
        //  Console.WriteLine(item);
        // }

        #endregion

        #region Generation Operators - Immediate Execution

        /*
         * The Only Way For Calling The Generation Operator  => as Static Method Through  "Enumerable" Class
         */
        // var Result = Enumerable.Range(1, 100); // Generate a sequence of integers from 1 to 100
        //
        // Result = Enumerable.Range(1, 10);// Generate a sequence of integers from 1 to 10
        //
        // Result = Enumerable.Empty<int>(); // Return Empty Collection

        #endregion

        #region Set Operators - Union Family Operators Union | UnionBy | Concat | Distinct | Distinct By | Intersect | Intersect By | Except | ExceptBy

        /*
         * Must make override for Equals and GetHashCode
         * Must Implement IEqualityComparer
         * Must Implement IEquatable
         */

        #region Union | UnionBy

        // var Seq01 = Enumerable.Range(0, 100);
        // var Seq02 = Enumerable.Range(50, 100);

        // var Result = Seq01.Union(Seq01); // Merging With Removing Duplicates
        // Result = Seq01.Union(Seq02, EqualityComparer<int>.Default); // Merging With Removing Duplicates Based on Custom Equality Comparer

        /* UnionBy By*/
        // var pro01 = new List<Product>() { new Product(){ ProductID = 1 , ProductName = "ahmed"}};
        // var pro02 = new List<Product>() { new Product(){ ProductID = 2 , ProductName = "marwan"}};

        // var unionBy = pro01.UnionBy(pro02, p => p.ProductName ); // Merging With Removing Duplicates Based on Custom Equality Comparer as Predicate

        #endregion

        #region Concat

        //
        // var Seq01 = Enumerable.Range(0, 100);
        // var Seq02 = Enumerable.Range(50, 100);

        // Result = Seq01.Union(Seq02, EqualityComparer<int>.Default); // Merging With Removing Duplicates Based on Custom Equality Comparer

        // var Result = Seq01.Concat(Seq01); // Merging Without Removing Duplicates 

        //  #endregion

        #endregion

        #region Distinct

        // var Seq01 = Enumerable.Range(0, 100);
        // var Result = Seq01.Distinct(); // Removing Duplicates 
        // var Resuslt = Seq01.Distinct(new ObjectEqualityCommparer); // Removing Duplicates Based on Custom Equality Comparer 

        // var pro01 = new List<Product>() { new Product(){ ProductID = 1 , ProductName = "ahmed"}};
        // var Result = pro01.DistinctBy(p => p.ProductID); 

        #endregion

        #region Intersect

        // var pro01 = new List<Product>() { new Product(){ ProductID = 1 , ProductName = "ahmed"}};
        // var pro02 = new List<Product>() { new Product(){ ProductID = 2 , ProductName = "marwan"}};

        // var Result = pro01.Intersect(pro02); // Return Common Elements Between Two Sequences 

        // Result = pro01.Intersect(pro02, EqualityComparer<Product>.Default); // Return Common Elements Between Two Sequences Based on Custom Equality Comparer

        // Result = pro01.IntersectBy<Product, long>(pro02.select(p1 => p1.ProductID), p => p.ProductID); // Return Common Elements Between Two Sequences Based on Custom Equality Comparer as Predicate

        // Result = pro01.IntersectBy(pro02.Select(p => p.ProductID), p => p.ProductID);

        #endregion

        #region Except

        // var Seq01 = Enumerable.Range(0, 100);
        // var Result = Seq01.Except(Seq02); // Return Elements in the First Sequence That Are Not in the Second Sequence  

        // var pro01 = new List<Product>() { new Product(){ ProductID = 1 , ProductName = "ahmed"}};
        // var pro02 = new List<Product>() { new Product(){ ProductID = 2 , ProductName = "marwan"}};

        // var Result = pro01.Except(pro02); // Return Elements in the First Sequence That Are Not in the Second Sequence

        // Result = pro01.Except(pro02, EqualityComparer<Product>.Default); // Return Elements in the First Sequence That Are Not in the Second Sequence Based on Custom Equality Comparer

        // Result = pro01.ExceptBy<Product, long>(pro02.Select<Product, long>(p1 => p1.ProductID), p => p.ProductID); // Return Elements in the First Sequence That Are Not in the Second Sequence Based on Custom Equality Comparer as Predicate

        #endregion

        #region Quantifier Operators - Return Boolean Value

        /*
         * Return True if the collection is not empty
         */
        // Console.WriteLine(ProductList.Any()); 
        //
        // /*
        //  * Any : Return True if the collection contains an element that satisfies the condition.
        //  */
        // Console.WriteLine(ProductList.Any(p => p.ProductID == 1)); // Return True if the collection contains an element with ProductID == 1 
        //
        // /*
        //  * All: Return True if all elements in the collection satisfy the condition.
        //  */
        // Console.WriteLine(ProductList.All(p => p.UnitPrice > 0));
        //
        // /*
        //  * Contains: Return True if the collection contains a specific element.
        //  */
        // Console.WriteLine(ProductList.Contains(new Product() {ProductID = 1}));
        //
        // /*
        //  *  Return True if the collection contains a specific element based on a custom equality comparer
        //  */
        // Console.WriteLine(ProductList.Contains(new Product() {ProductID = 1}, EqualityComparer<Product>.Default));


        /*
         * SequenceEqual: Return True if two sequences are equal.
         */
        // var Seq01 = Enumerable.Range(0, 100);
        // var Seq02 = Enumerable.Range(0, 100);
        //
        // Seq01.SequenceEqual(Seq02); 

        #endregion

        #endregion

        #region Transformation Operators Zip

        // List<string> Words = new List<string>() {"one", "two", "three", "four"};
        // int[] number = {1, 2, 3, 4};
        // int[] number02 = {1, 2, 3, 4};
        //
        // /*
        //  * Zip: Combines two sequences into a single sequence of pairs.
        //  */
        // var Result01 = number.Zip(Words); // Return a collection of tuples containing elements from both sequences
        //
        // /*
        //  * The `Zip` method has an overload that takes a lambda expression as a parameter.
        //  */
        // var Result02 = number.Zip(Words, (n, w) => $"{n} - {w}"); // Return a collection of strings containing elements from both sequences
        //
        // var Result03 = number.Zip(number,number02); // Return a collection of tuples containing elements from there sequences

        #endregion

        #region Grouping Operators - GroupBy | Chunk

        #region Example_01

        /* Query Expressions */
        // var Result = from p in ProductList
        //  group p by p.Category;
        //
        // /* Fluent Syntax  */
        // Result = ProductList.GroupBy(p => p.Category);
        //
        //
        // foreach (var group in Result)
        // {
        //  foreach (var product in group) // Category
        //  {
        //   Console.WriteLine($"{product}"); 
        //  }
        // }

        #endregion

        #region Example_02

        /* Query Syntax*/
        // var Result = from p in ProductList
        //  where p.UnitPrice > 0
        //  group p by p.Category
        //  into ProdGroupe
        //  where ProdGroupe.Count() > 10
        //  select new { Categery = ProdGroupe.Key ,Count = ProdGroupe.Count()};
        //
        // /* Fluent Syntax */
        // var Result02 = ProductList.Where(p => p.UnitPrice > 0)
        //  .GroupBy(p => p.Category)
        //  .Where(prodGroup => prodGroup.Count() > 10)
        //  .Select(prodGroup => new
        //  {
        //   Ctegory = prodGroup.Key,
        //   Count = prodGroup.Count()
        //  });

        #endregion

        #region Chunk

        // var Fruits = new string[] { "Banana", " Pear", "Apple ", "Orange " };
        //
        // var chunk = Fruits.Chunk(3);
        //
        // foreach (var item in chunk)
        // {
        //  Console.WriteLine(item);
        // }

        #endregion

        #endregion

        #region Partition Operators - Take , Skip , TakeLast , SkipLast , TakeWhile , SkipWhile

        #region Take , Skip , TakeLast , SkipLast

        // var Result = ProductList.Where(P => P.UnitPrice > 0).Take(5); // Get Five Elements 
        //     Result = ProductList.Where(P => P.UnitPrice > 0).TakeLast(5); // Get Last Five Elements
        //    
        //     Result = ProductList.Where(P => P.UnitPrice > 0).Skip(5); // Get ALl Elements And Skip First 5 Elements 
        //     Result = ProductList.Where(P => P.UnitPrice > 0).SkipLast(5); // Get ALl Elements And Skip Last 5 Elements 
        //     

        #endregion


        #region TakeWhile , SkipWhile

        //
        // int[] num = { 10, 20, 30, 10, 20, 30 };
        // /*
        //  * whright the docs form githup copiltiot
        //  */
        //
        // /* TakeWhile */
        // var Result = num.TakeWhile((number,index) => number > index );
        //
        // /* SkipWhile */
        //  Result = num.SkipWhile((number) => number %3 != 0 );
        //
        //
        // foreach (var item in Result)
        // {
        //  Console.WriteLine(item);
        // }               

        #endregion

        #endregion

        #region Let | Into
     //
     //    var Names = new List<string> { "ahmed", "mohamed", "ali", "marwan" };
     //    var Result = from n in Names
     //        select Regex.Replace(n, "[aeiou]", string.Empty)
     //        // Restart the Query with introducing new variable : NoVomeName
     //        into NoVomeName
     //        where NoVomeName.Length > 3
     //        select NoVomeName;
     //    
     //
     // Result = from n in Names
     //     let NoVomeName = Regex.Replace(n, "[aeiou]", string.Empty)
     //     // Continue the Query with Add Range variable: NoVomeName
     //     where NoVomeName.Length > 3
     //     select NoVomeName;
     //
     //
     // Result = Names.Select(n => Regex.Replace(n, "[aeiou]", string.Empty))
     //  .Where(novoweName => novoweName.Length > 3);


     #endregion

        /*
         * LINQPad: https://www.linqpad.net/
         */
     
     #endregion

     #region Search For Immediate Execution && Deferred Execution

     #endregion
    }
}