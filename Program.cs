namespace CricleAreaCalculator
{
    internal class Program
    {
        public static double CricleAreaCalculator(double radius)
        {
            return Math.PI * radius * radius;
        }
        public static double GetNumberFromUser()
        {
            Console.WriteLine("Enter the radius of the circle:");
            var numStr = Console.ReadLine();
            if (string.IsNullOrEmpty(numStr))
            {
                return 0;
            }
            numStr = numStr.Trim();
            double radius = double.Parse(numStr);
            return radius;
        }
        public static void Main(string[] args)
        {
            double radius = GetNumberFromUser();
            Console.WriteLine("Radius = " + radius);
            double area = CricleAreaCalculator(radius);
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}