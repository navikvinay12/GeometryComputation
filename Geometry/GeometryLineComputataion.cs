namespace Geometry
{
    internal class GeometryLineComputataion
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Geometry computation on Line Comparison program!\n");
        }
        static void Main(string[] args)
        {
            Welcome();
            Console.WriteLine("Taking you to enter coordinates of Line 1");
            double line1Distance = LineComparison.LineDistance();         //output of Line 1 distance
            Console.WriteLine("Taking you to enter coordinates of Line 2");
            double line2Distance = LineComparison.LineDistance();         //output of Line 2 distance
            LineComparison.EqualsMethod(line1Distance, line2Distance);         //Equals()
            LineComparison.CompareMethod(line1Distance, line2Distance);        //CompareTo()
        }
    }
}