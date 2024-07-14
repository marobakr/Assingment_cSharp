using System;

namespace Demo_Ass_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Regualr Example Without Incapsulation
            /*   Employee Emp = new Employee(10, "marwan", 10000);
               Emp.id = 10;
               Console.WriteLine(Emp.id);*/
            #endregion

            #region  Example Witt Incapsulation [Get ,Set]
            /*      Employee Emp = new Employee(10, "marwan", 10000);
                // Emp.Name; // Canot Set Name Directly Using Atterbute ❌❌❌
                Emp.SetName("ahmed");
                Console.WriteLine(Emp.GetName());*/
            #endregion

            #region With Full Property 
            /*      Employee Emp = new Employee(10, "marwan", 10000);
                  Emp.Salary = 200;
                  Console.WriteLine(Emp.Salary);*/
            #endregion

            #region With ReadOnly
            /*     Employee Emp = new Employee(10, "marwan", 10000);
                 Console.WriteLine(Emp.FullName);*/
            #endregion

            #region Indexer
            PhoneBook Note = new PhoneBook(3);
            Note.addPerson(0, "Ahmed", 123);
            Note.SetNumber("Ahmed", 555);

            Note["Ahmed"] = 99; // Use Indexer For Setter
            Console.WriteLine(Note["Ahmed"]); // Use Indexer For Getter
            #endregion
        }
    }
}
