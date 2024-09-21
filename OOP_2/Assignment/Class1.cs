using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_2
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} , {Age}";
        }

    }
}
