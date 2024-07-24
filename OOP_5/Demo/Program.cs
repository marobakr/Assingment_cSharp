using Session_4.Oprator_Overloading;
using Session_4.Oprator_Overloading.Partial;

namespace Session_4;

class Program
{
    static void Main(string[] args)
    {
    #region  Abstract Class , Method , Property
        // Rect rectangl = new Rect()
        // {
        //     Dim01 = 10,
        //     Dim02 = 20
        // };
        //
        // Console.WriteLine($"the Area is : {rectangl.CalcArea()}");
        // Console.WriteLine($"the Perimeter of Area is : { rectangl.Perimeter}");
        // Circle circle = new Circle(10);
        // Console.WriteLine($"the Circle Permit = {circle.Perimeter}");
        // Console.WriteLine($"Circle Area = {circle.CalcArea()}");
    #endregion


    #region Built-in OverLoading 
    // Complex C1 = new Complex() { Real = 2, Image = 3 };
    // Complex C2 = new Complex(){ Real = 3, Image = 5 };;
    // Complex C3 = default;
    
    /* PLus Operator */
    // C3 = C1 + C2;
    // Console.WriteLine($"c1 = {C1}");
    // Console.WriteLine($"c2 = {C2}");
    // Console.WriteLine($"c3 = {C3}");
    //
    // /* POst Increament */
    // Complex increament = ++C1;
    // Console.WriteLine($"increament = {increament}");
    
    /* Greater Than*/
    // if (C1 > C2)
    //     Console.WriteLine("c1 is greater than c2");
    // else
    // {
    //     Console.WriteLine("c2 is greater than c1"); 
    // }
    
    /* Explicit Casting (int) */
        // object obj = 5;
        // int X = (int) obj;
        // Console.WriteLine(X);
        //
    /* implicit Casting (string) */
       // string str =  C1;
       // Console.WriteLine(str);
       #endregion

    #region User-defined OverLoading

       // User user = new User()
       // {
       //     Fullname = "marwan abubakr",
       //     Email = "dev@marobakr.com",
       //     Id = 10,
       //     Password = "102030",
       //     SecuritySteamp = Guid.NewGuid().ToString(),
       // };
       // /* Mapping (Casting) Manual */
       // UserViewModel userViewModel = (UserViewModel) user;
       // Console.WriteLine(userViewModel.Id);
       // Console.WriteLine(userViewModel.Email);
       // Console.WriteLine(userViewModel.Fname);


       #endregion

    #region static Member Method


       /*
       Utility utility01 = new Utility(1, 3);
       Utility utility02 = new Utility(1, 3);
       */

       /*
        * the Result Of Calling Method "CMToInch"
        * won't Differ By the Reference Of Object State
        * so must Change this Mehod TO Static Member Method 
        * */
       
       /* invalid Invoke Function THORW Object */
       // Console.WriteLine(utility02.CMToInch(245));
       // Console.WriteLine(utility01.CMToInch(245));

       // Console.WriteLine(Utility.CMToInch(245));
       // Console.WriteLine(Utility.CMToInch(245));


       #endregion


       #region Partial Class

       Employee emp = new Employee();
       emp.Salary = 40;
       emp.Age = 20;
       emp.Name = "marwan";

       #endregion
    }
} 
// class is a data type 
// link development  