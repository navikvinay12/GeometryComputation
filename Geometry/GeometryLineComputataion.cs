namespace Geometry
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

            double d1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine($"First co-ordinates is {x1},{y1} & Second Co-ordinates is {x2},{y2}");
            return d1;
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
        }
    }
}