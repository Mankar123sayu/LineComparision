using System;
namespace LineComparision
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linecomparision problem");
            Console.WriteLine("Enter x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength calculateLength1 = new CalculateLength(x1, x2, y1, y2);
            double line1 = calculateLength1.Calculate();
            CalculateLength calculateLength2 = new CalculateLength(2, 3, 4, 5);
            double line2 = calculateLength2.Calculate();
            calculateLength2.CheckEquality(line1, line2);
        }
    }
}