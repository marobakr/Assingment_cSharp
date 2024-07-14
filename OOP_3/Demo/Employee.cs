using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public  void MyFunOne()
        {
            Console.WriteLine("i am an employee");
        }
        public virtual void MyFunTwo()
        {
            Console.WriteLine($"employee : id {Id} , Name:{Name} ,Age:{Age}");
        }
    }

    internal class fullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public new void MyFunOne()
        {
            Console.WriteLine("i am a full time employee");
        }
        public override void MyFunTwo()
        {
            Console.WriteLine($"full employee : id {Id} , Name:{Name} ,Age:{Age}");
        }
    }

    internal class PartTimeEmployee : Employee
    {

        public decimal HourRate { get; set; }
        public decimal CounterOfHourse { get; set; }

        public new void MyFunOne()
        {
            Console.WriteLine("i am a part time employee");
        }
        public override void MyFunTwo()
        {
            Console.WriteLine($"part employee : id {Id} , Name:{Name} ,Age:{Age}");
        }
    }
}
