namespace assignment;
using static ListGenerators;


class Program
{
    static void Main(string[] args)
    {

        #region LINQ - Restriction Operators

        // // 1. Find all products that are out of stock
        // var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
        //
        // // 2. Find all products that are in stock and cost more than 3.00 per unit
        // var inStockAndExpensiveProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
        //
        // // 3. Returns digits whose name is shorter than their value
        // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        // var shortNamedDigits = Arr.Where((name, index) => name.Length < index);
        //
        //
        // /* ================ LINQ - Aggregate Operators ================ */
        // // 1. Find all products that are out of stock
        // var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
        //
        // // 2. Find all products that are in stock and cost more than 3.00 per unit
        // var inStockAndExpensiveProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
        //
        // // 3. Returns digits whose name is shorter than their value
        // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        // var shortNamedDigits = Arr.Where((name, index) => name.Length < index);


        #endregion

        #region LINQ - Aggregate Operators
        // // 1. Uses Count to get the number of odd numbers in the array
        // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var oddNumbersCount = numbers.Count(n => n % 2 != 0);
        //
        // // 2. Return a list of customers and how many orders each has
        // var customerOrderCounts = CustomerList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Length });
        //
        // // 3. Return a list of categories and how many products each has
        // var categoryProductCounts = ProductList.GroupBy(p => p.Category)
        //                                        .Select(g => new { Category = g.Key, ProductCount = g.Count() });
        //
        // // 4. Get the total of the numbers in an array
        // var totalSum = numbers.Sum();
        //
        // // 5. Get the total number of characters of all words in dictionary_english.txt
        // string[] dictionaryWords = System.IO.File.ReadAllLines("dictionary_english.txt");
        // var totalCharacters = dictionaryWords.Sum(word => word.Length);
        //
        // // 6. Get the length of the shortest word in dictionary_english.txt
        // var shortestWordLength = dictionaryWords.Min(word => word.Length);
        //
        // // 7. Get the length of the longest word in dictionary_english.txt
        // var longestWordLength = dictionaryWords.Max(word => word.Length);
        //
        // // 8. Get the average length of the words in dictionary_english.txt
        // var averageWordLength = dictionaryWords.Average(word => word.Length);
        //
        // // 9. Get the total units in stock for each product category
        // var totalUnitsInStockByCategory = ProductList.GroupBy(p => p.Category)
        //                                              .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
        //
        // // 10. Get the cheapest price among each category's products
        // var cheapestPriceByCategory = ProductList.GroupBy(p => p.Category)
        //                                          .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
        //
        // // 11. Get the products with the cheapest price in each category (Use Let)
        // var cheapestProductsByCategory = ProductList.GroupBy(p => p.Category)
        //                                             .Select(g => new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice)) });
        //
        // // 12. Get the most expensive price among each category's products
        // var mostExpensivePriceByCategory = ProductList.GroupBy(p => p.Category)
        //                                               .Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) });
        //
        // // 13. Get the products with the most expensive price in each category
        // var mostExpensiveProductsByCategory = ProductList.GroupBy(p => p.Category)
        //                                                  .Select(g => new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)) });
        //
        // // 14. Get the average price of each category's products
        // var averagePriceByCategory = ProductList.GroupBy(p => p.Category);
        #endregion
        
        #region LINQ - Ordering Operators
        // // 1. Sort a list of products by name
        // var productsSortedByName = ProductList.OrderBy(p => p.ProductName);
        //
        // // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array
        // string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        // var caseInsensitiveSortedWords = words.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
        //
        // // 3. Sort a list of products by units in stock from highest to lowest
        // var productsSortedByUnitsInStock = ProductList.OrderByDescending(p => p.UnitsInStock);
        //
        // // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself
        // string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        // var digitsSortedByLengthAndName = digits.OrderBy(d => d.Length).ThenBy(d => d);
        //
        // // 5. Sort first by word length and then by a case-insensitive sort of the words in an array
        // var wordsSortedByLengthAndCaseInsensitive = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
        //
        // // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest
        // var productsSortedByCategoryAndPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
        //
        // // 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array
        // var wordsSortedByLengthAndCaseInsensitiveDesc = words.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
        //
        // // 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array
        // var digitsWithSecondLetterIReversed = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
        //
        #endregion
        
        #region LINQ - Transformation Operators

        // // 1. Return a sequence of just the names of a list of products
        // var productNames = ProductList.Select(p => p.ProductName);
        //
        // // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)
        // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        // var upperLowerWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
        //
        // // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type
        // var productDetails = ProductList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice, p.UnitsInStock });
        //
        // // 4. Determine if the value of int in an array matches their position in the array
        // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var valueMatchesPosition = numbers.Select((value, index) => value == index);
        //
        // // 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB
        // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        // int[] numbersB = { 1, 3, 5, 7, 8 };
        // var pairs = from a in numbersA
        //     from b in numbersB
        //     where a < b
        //     select new { a, b };
        //
        // // 6. Select all orders where the order total is less than 500.00
        // var ordersLessThan500 = CustomerList.SelectMany(c => c.Orders)
        //     .Where(o => o.Total < 500.00M);
        //
        // // 7. Select all orders where the order was made in 1998 or later
        // var ordersFrom1998OrLater = CustomerList.SelectMany(c => c.Orders)
        //     .Where(o => o.OrderDate.Year >= 1998);

        #endregion
        
        #region LINQ - Set Operators

        // 1. Find the unique Category names from Product List
        var uniqueCategories = ProductList.Select(p => p.Category).Distinct();

        // 2. Produce a sequence containing the unique first letter from both product and customer names
        var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0])
            .Union(CustomerList.Select(c => c.CustomerName[0]))
            .Distinct();

        // 3. Create one sequence that contains the common first letter from both product and customer names
        var commonFirstLetters = ProductList.Select(p => p.ProductName[0])
            .Intersect(CustomerList.Select(c => c.CustomerName[0]));

        // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names
        var productFirstLettersNotInCustomers = ProductList.Select(p => p.ProductName[0])
            .Except(CustomerList.Select(c => c.CustomerName[0]));

        // 5. Create one sequence that contains the last three characters in each name of all customers and products, including any duplicates
        var lastThreeCharacters = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));

        #endregion
        
        #region LINQ - Partitioning Operators

        // // 1. Get the first 3 orders from customers in Washington
        // var first3OrdersFromWashington = CustomerList.Where(c => c.Region == "WA")
        //     .SelectMany(c => c.Orders)
        //     .Take(3);
        //
        // // 2. Get all but the first 2 orders from customers in Washington
        // var allButFirst2OrdersFromWashington = CustomerList.Where(c => c.Region == "WA")
        //     .SelectMany(c => c.Orders)
        //     .Skip(2);
        //
        // // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array
        // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var elementsUntilLessThanPosition = numbers.TakeWhile((value, index) => value >= index);
        //
        // // 4. Get the elements of the array starting from the first element divisible by 3
        // var elementsFromFirstDivisibleBy3 = numbers.SkipWhile(n => n % 3 != 0);
        //
        // // 5. Get the elements of the array starting from the first element less than its position
        // var elementsFromFirstLessThanPosition = numbers.SkipWhile((value, index) => value >= index);

        #endregion
        
        #region LINQ - Quantifiers

        // // 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'
        // string[] dictionaryWords = System.IO.File.ReadAllLines("dictionary_english.txt");
        // bool containsEi = dictionaryWords.Any(word => word.Contains("ei"));
        //
        // // 2. Return a grouped list of products only for categories that have at least one product that is out of stock
        // var categoriesWithOutOfStockProducts = ProductList.GroupBy(p => p.Category)
        //     .Where(g => g.Any(p => p.UnitsInStock == 0))
        //     .Select(g => new { Category = g.Key, Products = g.ToList() });
        //
        // // 3. Return a grouped list of products only for categories that have all of their products in stock
        // var categoriesWithAllProductsInStock = ProductList.GroupBy(p => p.Category)
        //     .Where(g => g.All(p => p.UnitsInStock > 0))
        //     .Select(g => new { Category = g.Key, Products = g.ToList() });

        #endregion

        #region LINQ – Grouping Operators
        // 1. Partition a list of numbers by their remainder when divided by 5
        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        var groupedByRemainder = numbers.GroupBy(n => n % 5);

        foreach (var group in groupedByRemainder)
        {
            Console.WriteLine($"Remainder {group.Key}: {string.Join(", ", group)}");
        }

        // 2. Partition a list of words by their first letter
        string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
        var groupedByFirstLetter = dictionaryWords.GroupBy(word => word[0]);

        foreach (var group in groupedByFirstLetter)
        {
            Console.WriteLine($"First letter {group.Key}: {string.Join(", ", group)}");
        }

        // 3. Group words that consist of the same characters together
        string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
        var groupedByCharacters = Arr.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));

        foreach (var group in groupedByCharacters)
        {
            Console.WriteLine($"Group: {string.Join(", ", group)}");
        }
        

        #endregion

    }
}