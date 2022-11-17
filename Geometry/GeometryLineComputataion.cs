﻿namespace Geometry
{
    internal class GeometryLineComputataion
    {
        public static double LineDistance()
        {
            Console.WriteLine("Enter the first coordinates x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinates x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    //with using Pow function.
            Console.WriteLine($"Provided co-ordinates (x1,y1):({x1},{y1})  &  (x2,y2):({x2},{y2})");
            return d1;
        }
        public static void EqualsMethod(double line1Distance, double line2Distance)
        {
            bool EqualsStatus = line1Distance.Equals(line2Distance);
            if (EqualsStatus)
            {
                Console.WriteLine("Length value of both Line 1 and Line 2 are EQUAL");
            }
            else
            {
                Console.WriteLine("Length value of Line 1 and Line 2 are NOT equal");
            }
        }
        public static void CompareMethod(double line1Distance, double line2Distance)
        {
            int CompareToStatus = line1Distance.CompareTo(line2Distance);
            if (CompareToStatus == 0)
            {
                Console.WriteLine("Both first and second lines are having Equal Length.");
            }
            else if (CompareToStatus < 0)
            {
                Console.WriteLine("Length of first line is less than second line.");
            }
            else
            {
                Console.WriteLine("Length of first line is greater than second line.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Taking you to enter coordinates of Line 1");
            double line1Distance = GeometryLineComputataion.LineDistance();
            Console.WriteLine($"Found Line 1 length value : {line1Distance}");
            Console.WriteLine("Taking you to enter coordinates of Line 2");
            double line2Distance = GeometryLineComputataion.LineDistance();
            Console.WriteLine($"Found Line 2 length value : {line2Distance}");
            Console.WriteLine();
            Console.WriteLine($"So finally got Line 1 length value : {line1Distance} & Line 2 length value : {line2Distance}");

            Console.Write("Using Equals Method output is :::: ");
            GeometryLineComputataion.EqualsMethod(line1Distance, line2Distance);

            Console.Write("Using Compare To Method output is ::::");
            GeometryLineComputataion.CompareMethod(line1Distance, line2Distance);
        }
    }
}