namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* =============== Execution For Call Function =============== */

            #region Call_1
            #region BY_ValueType
            /*    int Number = 10;
                /*
                 Passing by value means that when you pass an argument to a function,
                 a copy of the actual value is made and passed to the function.
                This means that any changes made to the parameter inside the function do not affect the original value.
                 /*
                Console.WriteLine($"before increament {Number}");
                Console.WriteLine(SumValueType(Number));
                Console.WriteLine($"after increament {Number}");

                #endregion*/
            #endregion

            #region BY_RefType
            /*   int Number = 10;
               *//*
                When you pass a value type parameter by reference using the ref keyword, the method receives a reference to the original variable.
               Any modifications made to the parameter within the method directly affect the original variable.
                *//*
               Console.WriteLine($"before increament {Number}");
               Console.WriteLine(SumValueType(ref Number));
               Console.WriteLine($"after increament {Number}");*/


            #endregion

            #endregion

            #region Call_2

            #region BY_ValueType
            /*   int[] Numbers = { 1, 2, 3 };
               *//*
               When you pass a reference type parameter by value, a copy of the reference (not the object itself) is passed to the method. 
               This means the method can modify the object the reference points to,
               but it cannot change the reference to point to a different object.
                *//*
               int Total = SumArray(Numbers);
               Console.WriteLine(Total);
               Console.WriteLine(Numbers[0]);

               #endregion*/
            #endregion

            #region BY_RefType
            /*    int[] Numbers = { 1, 2, 3 };
                *//*
               When you pass a reference type parameter by reference using the ref keyword, the method receives a reference to the original reference.
               This allows the method to modify the object and also change the reference to point to a different object.
                 *//*
                int Total = SumArray(ref Numbers);
                Console.WriteLine(Total);
                Console.WriteLine(Numbers[0]);*/

            #endregion


            #endregion

            #region Call_3
            /*  
                    Console.Write("Enter the first number for summation: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter the second number for summation: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.Write("Enter the first number for subtraction: ");
                    int num3 = int.Parse(Console.ReadLine());

                    Console.Write("Enter the second number for subtraction: ");
                    int num4 = int.Parse(Console.ReadLine());

                    int sumResult;
                    int subtractResult;

                    SummAndSub(num1, num2, num3, num4, out sumResult, out subtractResult);

                    Console.WriteLine($"The result of summation is: {sumResult}");
                    Console.WriteLine($"The result of subtraction is: {subtractResult}");*/
            #endregion

            #region Call_4

            /*     Console.Write("Enter a number: ");
                 int number = int.Parse(Console.ReadLine());

                 int sumOfDigits = SumOfDigits(number);

                 Console.WriteLine($"The sum of the digite {number} is: {sumOfDigits}");*/
            #endregion

            #region Call_5
            /*       Console.Write("Enter a number to check if is prime ");
                   if (int.TryParse(Console.ReadLine(), out int number))
                   {
                       bool isPrime = IsPrime(number);
                       // Display the result
                       Console.WriteLine($"{number} is {(isPrime ? "a prime number" : "not a prime number")}");
                   }*/
            #endregion

            #region Call_6

            /*    int[] numbers = { 1,2,3,4,5,6};

                int minValue;
                int maxValue;

                MinMaxNum(numbers, out minValue, out maxValue);

                Console.WriteLine($"The minimum is: {minValue}");
                Console.WriteLine($"The maximum is: {maxValue}");*/
            #endregion

            #region Call_7
            /*
                        Console.Write("Enter a number to calculate it: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            if (number < 0)
                            {
                                Console.WriteLine("Factorial is not defined for negative numbers.");
                            }
                            else
                            {
                                Console.WriteLine($"The factorial of {number} is: {Calculate(number)}");
                            }
                        }
            */
            #endregion

            #region Call_8
            /*   string str = "Marwan";
               int position = 0; 
               char newChar = 'H';

               Console.WriteLine($"Original: {str}");
               Console.WriteLine($"Modified: {ChangeChar(str, position, newChar)}");*/
            #endregion

        }

        /* =============== Execution For Declaration Function =============== */

        #region Ass_1

        #region BY_ValueType 
        /*     static int SumValueType(int num)
             {
                 num+=10;
                 return num;
             }*/
        #endregion

        #region BY_RefType
        /*    static int SumValueType(ref int num)
            {
                num+=10;
                return num;
            }
    */
        #endregion

        #endregion

        #region Ass_2

        #region BY_ValueType
        /*  static int SumArray(int[] Arr)
          {
              int Sum = 0;
              Arr[0] = 100;

              for (int i = 0; i < Arr.Length; i++)
              {
                  Sum += Arr[i];
              }

              return Sum;

          }*/
        #endregion

        #region BY_RefType
        /*    static int SumArray(ref int[] Arr)
            {
                int Sum = 0;
                Arr = new int[] { 10, 20, 30 };


                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += Arr[i];
                }

                return Sum;

            }*/

        #endregion

        #endregion

        #region Ass_3
        /*        static void SummAndSub(int add1, int add2, int sub1, int sub2, out int sum, out int Sub)
                {
                    sum = add1 + add2;
                    Sub = sub1 - sub2;
                }
        */
        #endregion

        #region Ass_4
        /*   static int SumOfDigits(int number)
           {
               int sum = 0;

               while (number != 0)
               {
                   sum += number % 10; 
                   number /= 10;       
               }

               return sum;
           }*/

        #endregion

        #region Ass_5

        /*        static bool IsPrime(int number)
                {
                    if (number <= 1) return false;
                    if (number == 2) return true;
                    if (number % 2 == 0) return false; 

                    int bound = (int)Math.Floor(Math.Sqrt(number));

                    for (int i = 3; i <= bound; i += 2)
                    {
                        if (number % i == 0) return false;
                    }

                    return true;
                }
        */
        #endregion

        #region Ass_6 

        /*        static void MinMaxNum(int[] arr, out int min, out int max)
                {

                    min = arr[0];
                    max = arr[1];

                    foreach (int num in arr)
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                        if (num > max)
                        {
                            max = num;
                        }
                    }
                }
        */

        #endregion

        #region Ass_7
        /*        static long Calculate(int number)
                {
                    int result = 1;

                    for (int i = 1; i <= number; i++)
                    {
                        result *= i;
                    }

                    return result;
                }
        */
        #endregion

        #region Ass_8

        /*        static string ChangeChar(string str, int position, char newChar)
                {

                    char[] chars = str.ToCharArray();
                    chars[position] = newChar;

                    return new string(chars);
                }
        */
        #endregion
    }
}
