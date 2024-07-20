using Demo.interfaces;

namespace Demo;

class Program
{
    
    #region  create reference from interface
    /*  can I create reference from interface to refer to object form class */
    public static void printNUmberFromSerides(ISeries  serices)
    {
        if (serices is not null)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{serices.Current}");
                serices.GetNext();
            }
            serices.Rest();
        }
    }
        

    #endregion
    
    static void Main(string[] args)
    {
        #region referenceFromInterface
        /*
         * can I invoke method into interface but must...
         * can I create reference from interface to refer to object form class
         * must the class be implemented the interface
         */
        
        /*IMyType referenceFromInterface = new MyClass();
        referenceFromInterface.Salary = 10;
        referenceFromInterface.MyFUn();
        referenceFromInterface.Print();*/
        

        #endregion
        
        #region serices
        /*// serices By Two#3# #2#
        SeriesByTwo SeriesByTwo = new SeriesByTwo();
        // serices By There#3# #2#
        SeriesByThere SeriesByThere = new SeriesByThere();
        printNUmberFromSerides(SeriesByTwo);
        Console.WriteLine("Start : SeriesByThere ");
        printNUmberFromSerides(SeriesByThere);  */
        #endregion
        
        #region AirPaln

        /*Imoveble airplan = new Aireplan();
        airplan.Left();*/

        #endregion
        
        #region Shallow Copy  
        /*
       * this Object `Arr1` hase Two references
       * this object become unReachable Object  { 10, 20, 30 };
       * Shallow Copy (سطحي)
       #1#
       */
        
        // int[] Arr1 =  { 10, 20, 30 };
        // int[] Arr2 =  { 40, 50, 60 };
        //
        // Console.WriteLine($"Arr1 = {Arr1.GetHashCode()}");
        // Console.WriteLine($"Arr2 = {Arr2.GetHashCode()}");
        //
        // Arr1 = Arr2;
        // Console.WriteLine($"Arr1 = {Arr1.GetHashCode()}");
        // Console.WriteLine($"Arr2 = {Arr2.GetHashCode()}");
        //
        // Arr2[0] = 1000;
        // Console.WriteLine($"Arr1 = {Arr1[0]}");
        // Console.WriteLine($"Arr2 = {Arr2[0]}");

  
        #endregion
        
        #region Deep Copy 
        /*
         * CLone Method : Will Generate NEW object  WIth New And DDifferent Identity [Refrences].
         * but With THe ASnae Objects Start [Data] Of Caller Object "Arr1"
         */
        
        // int[] Arr1 =  { 10, 20, 30 };
        // int[] Arr2 =  { 40, 50, 60 };
        // Console.WriteLine($"Arr1 = {Arr1.GetHashCode()}");
        // Console.WriteLine($"Arr2 = {Arr2.GetHashCode()}");
        // Arr2 = (int [] ) Arr1.Clone();
        // Arr2[0] = 1000;
        // Console.WriteLine($"Arr1 = {Arr1[0]}");
        // Console.WriteLine($"Arr2 = {Arr2[0]}");
        
        #endregion

        #region Shalow Copy

        Employee employee01 = new Employee(){Id = 40,Name = "Marwan", Salary = 200};
        Employee employee02 = new Employee(){Id = 20,Name = "Mona", Salary = 5000};
        Console.WriteLine("Before Shalow Copy");
        Console.WriteLine($"employee01 {employee01.GetHashCode()}");
        Console.WriteLine($"employee02 {employee02.GetHashCode()}");
        employee02 = employee01;
        
        Console.WriteLine("after Shalow Copy");
        
        Console.WriteLine($"employee01 {employee01.GetHashCode()}");
        Console.WriteLine($"employee02 {employee02.GetHashCode()}");

        #endregion
        
        #region Deep Copy WIth IClonable
        /*
         * CLone Method : Will Generate NEW object  WIth New And DDifferent Identity [Refrences].
         */
        // Console.WriteLine("after Deep Copy");
        // employee02 = (Employee)  employee01.Clone();
        // Console.WriteLine($"employee01 {employee01.GetHashCode()}");
        // Console.WriteLine($"employee02 {employee02.GetHashCode()}");

        #endregion
        
        #region Deep Copy With Constractor
        //
        // employee02 = new Employee(employee01);
        // Console.WriteLine($"employee01 {employee01.GetHashCode()}");
        // Console.WriteLine($"employee02 {employee02.GetHashCode()}");
        #endregion

        #region Compare

        // Employee[] employeess =
        // {
        //     new Employee() { Id = 20, Name = "Mona", Salary = 5000 },
        //     new Employee() { Id = 40, Name = "Marwan", Salary = 200 },
        //     new Employee() { Id = 20, Name = "Mona", Salary = 3000 },
        // };
        //
        // int Result = employeess[0].CompareTo(employeess[1]);
        // Console.WriteLine(Result);
        #endregion
    

    }
}