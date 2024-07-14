using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Animal
    {
        public String AnimalName;

        public Animal(string _AnimalName)
        {
            AnimalName = _AnimalName;
        }
        public int animalName { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

    }

    public class Dog : Animal
    {
        public Dog(string _AnimalName) : base(_AnimalName)
        {

        }

        /*  Overriding */
        public override void MakeSound()
        {
            Console.WriteLine($"{AnimalName} barks");
        }
    }

    public class Cat : Animal
    {
       public Cat(string _AnimalName) : base(_AnimalName){}
             public override void MakeSound()
              {
            Console.WriteLine($"{AnimalName} meows");
        }

    }
    public class Mouse : Animal
    {
        public Mouse(string _AnimalName) : base(_AnimalName)
        {

        }

        /* =========== New Key Word ===========*/
        public new void MakeSound()
        {
            Console.WriteLine($"{AnimalName} Runs");
        }
    }

    public class AnimalBinding : Animal
    {
        public AnimalBinding(string _AnimalName) : base(_AnimalName)
        {

        }

        public new void MakeSound()
        {
            Console.WriteLine($"Binding {AnimalName} Runs"); 
        }
        public void XBinding()
        {
            Console.WriteLine($"Binding");
        }

    }


}
