
namespace Demo_OOP_Ass_1

{
    internal class Program
    {
        #region Enum

        /*        public enum DaysOfWeek
                {
                    // Lables 
                    Sunday,    // 0 The Default start is "0"
                    Monday,    // 1
                    Tuesday,   // 2
                    Wednesday, // 3
                    Thursday,  // 4
                    Friday,    // 5
                    Saturday   // 6

                }*/
        public enum DaysOfWeek : Byte // byte = 8 bits [0:255]
        {
            // Labels 
            Sunday = 202,
            Monday,    // 203
            Tuesday,   // 204
            Wednesday, // 205
            Thursday,  // 206 ❌❌❌ (maximum is 255) 
        }
        public enum Gander : int // default
        {
            // can I declare multiple with the same underlying value
            Male = 1,
            M = 1,
            Female = 2,
        }

        [Flags]
        public enum Permission : byte
        {
            Delete = 1, Execute = 2, Read = 4, Write = 8
        }

        class Employee
        {
            public string Name;
            public int Age;
            public Permission Permission;

        }
        #endregion

        #region Struct
        #region Struct_1
        /*        public struct Point
                {
                    public int X;
                    public int Y;

                    // Parameterized constructor
                    public Point(int x, int y)
                    {
                        X = x;
                        Y = y;
                    }
                }*/
        #endregion

        #region Struct_2
       /* Public struct Point
        {
            public int X;
            public int Y;
        }*/
        #endregion

        #region Struct_3
        public struct Point
        {
            public int X;
            public int Y;

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        #endregion


        #endregion
        static void Main(string[] args)
        {
            #region Access Modifiers 
            /* Access Modifiers */
            // - Private
            // - Private Protected
            // - Protected
            // - Internal [Default]
            //     - `Internal`: The member is accessible only within files in the same `assembly`. It is useful for allowing access to members across different classes within the same application but not from outside.
            //     - `Assembly`:[within the same project, within the same library, within the same executable]

            // - Protected Internal

            // - `Public`
            //     - `Public`: The member is accessible from any other code. There are no restrictions on accessing public members.

            #endregion

            #region what you can write inside

            /*   what you can write inside the `class` or `struct` 
             * Attributes[fields] → Member Variables
             * Properties
                - full Property
                - automatic Property
                - indexer[spechial type]

            * Function
                - Constructor
                - Getter & Setter
                - Method

            * Events
             */

            /* What You Can Write Inside `NameSpaec` 
            * Class
            * Struct
            * Interface
            * Enum
             */

            /*What You Can Write Inside `Interface
             * Signature For Property
             * Signature For Method
             * Default implemented Method[C# 8.0 feature .NET Core 3.1 [2019] ]
             * `Signature` is :  (name, return type, parameters, modifiers)             
             */

            /*  Allow Access Modifiers
        
        * Access Modifier Allowed Inside `NameSpace
                - `Internal`[Default]
                - `Public`

        * Access Modifier Allowed Inside `Struct`
                - `Private`[Default]
                - `Internal
                - `Public
        
        * what I can’t wright `protected` and `private protected` and `internally protected` in struct?
            - `protected`, `private protected`, and `protected internal` cannot be used in `structs` because `structs` do not support inheritance
            
        * Access Modifier Allowed Inside `Class`
            - `All` the access levels you can write inside a class
            - `Private`[Default]

        * Access Modifier Allowed Inside `Interface`*
            - `Public` [Default]
             
             */

            #endregion

            #region Enum_Example
            #region Exam_1
            /*            DaysOfWeek Day = DaysOfWeek.Sunday;

                        if (Day == DaysOfWeek.Sunday)

                            if (Day == (DaysOfWeek)0) // or Explict 

                                Console.Write("i am available :)");
                            else
                                Console.Write("i am not available (:");*/
            #endregion

            #region Exam_2
            /*
                        DaysOfWeek Day = DaysOfWeek.Sunday;


                        if (Day == DaysOfWeek.Sunday)
                            if (Day == (DaysOfWeek)202) 

                                Console.WriteLine("i am available :)");

                            else
                                Console.WriteLine("i am not available (:");*/
            #endregion

            #region Exam_3
            string Gander = "male"; // male not equal Male
            Enum.TryParse(typeof(Gander), Gander, out object result); // boxing   

            Enum.TryParse<Gander>(Gander, true, out Gander Result);
            // second parameter : ignore case [small or capital case ]
            #endregion

            #region Exam_4
            Employee emp = new Employee();
            emp.Name = "Marwan";
            emp.Permission=(Permission)4;

            /*================ XOR ^ ================ */

            // if you wanna to add a new permission (Read)? Do XOR Operation

            emp.Permission = emp.Permission ^ Permission.Read; // look like x+= some value 

            // if you wanna to Remove [Deny] (Read)? Do XOR Operation
            // if Exisited? => it will remove it: If it not Exist => it will Added


            emp.Permission = emp.Permission ^ Permission.Read; // look like x+= some value 

            /*================ AND & ================ */

            // if you wanna to Check If some enum value [like read] has existed? Do & Operation
            // if [Read] is Existed? => it will return [Read] else ==> return Random Value 

            emp.Permission = emp.Permission & Permission.Read;


            if ((emp.Permission = emp.Permission & Permission.Read) == Permission.Read)
            {

                Console.WriteLine(" Read IS Esisted ");


            }
            else
            {
                emp.Permission = emp.Permission ^ Permission.Read;

            }

            /*================ OR | ================ */

            // if you wanna to Check If some enum value [like read] has existed or not Do OR Operation?
            // if Exisited? => Do Nothing: If not Existed => Do Add

            emp.Permission = emp.Permission | Permission.Read;


            #endregion

            #endregion

            #region Struct
            #region Exam_1
            /*            Point p = new Point(10, 20);
                        Console.WriteLine($"X: {p.X}, Y: {p.Y}"); // Output: X: 10, Y: 20*/
            #endregion

            #region Exam_2
            Point p; // No 'new' operator used

            // Accessing fields before initialization will result in compile-time error:
            // Console.WriteLine($"X: {p.X}, Y: {p.Y}"); // Compile-time error: Use of unassigned local variable 'p'

            // Initialize fields individually or via a parameterized constructor
            p.X = 10;
            p.Y = 20;

            Console.WriteLine($"X: {p.X}, Y: {p.Y}"); // Output: X: 10, Y: 20
            #endregion

            #region Exam_3
            Point po = new Point { X = 10, Y = 20 };
            Console.WriteLine(po); // Output: (10, 20)
            #endregion

            #endregion
        }
    }
}
