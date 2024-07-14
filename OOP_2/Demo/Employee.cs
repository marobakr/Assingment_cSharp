using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo_Ass_2
{
    internal class Employee
    {
        public int id;
        private string Name;
        private decimal salary;

        public Employee(int _id, string _name, decimal _salary)
        {
            Name = _name;
            id = _id;
            salary = _salary;
        }

        public override string ToString()
        {
            return $"Employee ID: {id}, Name: {Name}, Salary: {salary:C}";
        }

        #region  Example Witt Method [Get ,Set]
        // Get
        /*   public string GetName()
           {
               return Name;

               }

           // Set
           public string SetName(string newName)
           {
               return Name = newName;
           }
   */
        #endregion

        #region With Full Property 
        /*        public decimal Salary { get; set; }
        */
        #endregion

        #region With ReadOnly
        /*     public string FullName
             {
                 get { return $"{Name}"; }
             }*/
        #endregion

    }
}



