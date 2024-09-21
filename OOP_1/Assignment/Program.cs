namespace Assignment_OOP_1
{
    internal class Program
    {
        #region Enum
        #region  ASS_1
        internal enum WeekDays
        {
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        #endregion

        #region Ass_2
        internal enum Season
        {
            Spring = 1,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region Ass_3
        [Flags]
        internal enum Permissions
        {

            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        #endregion

        #region Ass_4
        internal enum Colors
        {

            Red, Green, Blue
        }
        #endregion

        #endregion

        #region Struct Ass_5
        public struct Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double _x, double _y)
            {
                X = _x;
                Y = _y;
            }
            public double DistanceTo(Point p)
            {
                double deltaX = p.X - X;
                double deltaY = p.Y - Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Ass_1
            /*  foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek))) {
                  Console.WriteLine(typeof(DayOfWeek));
                  Console.WriteLine(day);
              }*/
            #endregion

            #region Ass2
            /*      Console.WriteLine("Enter a season name ");
                  string input = Console.ReadLine();

                  if (Enum.TryParse(input, true, out Season season))
                  {
                      switch (season)
                      {
                          case Season.Spring:
                              Console.WriteLine("Spring: March to May");
                              break;
                          case Season.Summer:
                              Console.WriteLine("Summer: June to August");
                              break;
                          case Season.Autumn:
                              Console.WriteLine("Autumn: September to November");
                              break;
                          case Season.Winter:
                              Console.WriteLine("Winter: December to February");
                              break;
                          default:
                              Console.WriteLine("Unknown season.");
                              break;
                      }
                  }*/

            #endregion

            #region Ass_3
            /*    Console.WriteLine("enter the num of Permissions wanna delete it range:[1,2,4,8] ");
                int.TryParse(Console.ReadLine(), out int num);
                Permissions permissions = (Permissions)15;
                permissions = permissions ^ (Permissions)num;
                Console.WriteLine(permissions);*/

            #endregion

            #region Ass_4
            /*
                        Console.WriteLine("explore the primary color");
                        string input = Console.ReadLine();
                        Enum.TryParse(input, true, out Colors outColor);

                         foreach (Colors color in Enum.GetValues(typeof(Colors))) {
                            if (outColor == color)
                            {
                                Console.WriteLine($"the color {color} is a primary");
                            }
                            else
                                Console.WriteLine($"the color {color} is not a primary");

                        }*/

            #endregion

            #region Ass_5
      /*      Console.WriteLine("Enter Point 1 (X Y): ");
            string[] input1 = Console.ReadLine().Split();
            double x1 = double.Parse(input1[0]);
            double y1 = double.Parse(input1[1]);

            Console.WriteLine("Enter Point 2 (X Y): ");
            string[] input2 = Console.ReadLine().Split();
            double x2 = double.Parse(input2[0]);
            double y2 = double.Parse(input2[1]);

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);

            double distance = point1.DistanceTo(point2);

            Console.WriteLine($"Distance between P 1 and P 2: {distance}");*/
            #endregion
        }
    }
}
