namespace Assignment_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*============== Part 01 ==============  */
                 /* you will find it in Demo Project*/

            #region Ass_1


            #endregion

            /*============== Part 02 ==============  */

            #region Ass_1
            /*
                        Person[] Persons = new Person[3];
                        Persons[0] = new Person
                        {
                            Name = "user1",
                            Age = 1,
                        };

                        Persons[1] = new Person
                        {
                            Name = "user2",
                            Age = 2,
                        };
                        Persons[2] = new Person
                        {
                            Name = "user3",
                            Age = 3,
                        };


                        foreach (Person person in Persons) {
                            Console.WriteLine(person);
                        }*/


            #endregion

            #region Ass_2
            /*         Person[] Persons = new Person[3];

               for (int i = 0; i<Persons.Length;i++ )
               {
                   Console.WriteLine($"enter details for person num {i +1}");
                   Console.Write("enter your name");
                   Persons[i] = new Person();
                   Persons[i].Name = Console.ReadLine();
                   Console.WriteLine("enter your Age");
                   Persons[i].Age = int.Parse(Console.ReadLine());
               }
               foreach (Person person in Persons)
               {
                   Console.WriteLine(person);
               }*/

            #endregion

            /*============== Part 03 ==============  */

            #region Ass_1
        /*    Employee[] empArr = new Employee[3];

            empArr[0] = new Employee(1, "Alice", "F", SecurityLevel.DBA, 7000m, new HiringDate(15, 6, 2020));

            empArr[1] = new Employee(2, "Bob", "M", SecurityLevel.Guest, 300m, new HiringDate(20, 1, 2023));

            empArr[2] = new Employee(3, "Charlie", "M", SecurityLevel.Developer, 800m, new HiringDate(5, 3, 2018));

            foreach (var employee in empArr)
            {
                Console.WriteLine(employee);
            }*/
            #endregion

        }
    }
}
