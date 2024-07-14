using System.Security.Cryptography.X509Certificates;

namespace Assignment_3
{
    internal class Program
    {
        /*============= Example For Overloding  ============= */
        public static int Sum(int a)
        {
            return a;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int d)
        {
            return a + b;
        }

        /*============= Example For Binding  ============= */

      public  static void ProcessEmployee(Employee employee) {
            if (employee is not null) {
                employee.MyFunOne();
                employee.MyFunTwo();
            }
        }
        static void Main(string[] args)
        {
            /*============= Overloding ============= */

            Console.WriteLine("Hello, World!");
            int Result = Program.Sum(10);
            int ResultTow = Program.Sum(10, 20);
            int ResultThere = Program.Sum(10, 30, 10);

            /*============= Overriding ============= */
            Animal Ani = new Animal("animal");
            Ani.MakeSound();
            Cat cat = new Cat("Cat");
            cat.MakeSound();
            Dog dog = new Dog("Dog");
            dog.MakeSound();
            Mouse mouse = new Mouse("Mouse");
            mouse.MakeSound();


            /*============= Binding============= */

            Animal dogBinding = new AnimalBinding("AnimalBinding");
            /*
             * Static Binding (Early Binding):
             * it's dosn't run `MakeSound` for child
             */

            dogBinding.MakeSound();

            /*
            * Dynamic Binding (Late Binding):
            * it's will run `MakeSound` for child
            */


            /*============= Example For Binding ============= */

            fullTimeEmployee fullEmployee = new fullTimeEmployee();
            PartTimeEmployee PartEmployee = new PartTimeEmployee();

            ProcessEmployee(PartEmployee);
           ProcessEmployee(fullEmployee);

        }
    }
}
