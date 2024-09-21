using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_2
{
    internal class Employee
    {
        private string _gender;

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
            }
        }

        public Employee(int id, string name, string gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, " +
                   $"Security Level: {SecurityLevel}, Salary: {Salary:C}, " +
                   $"Hire Date: {HireDate}";
        }
    }
}
