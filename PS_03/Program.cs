using System;

namespace PS_03_Area
{
    class Program
    {
        public static void Main(string[] args)
        {
            Triangle_Area();
        }

        public static void Triangle_Area(double a = 10, double b = 10, double c = 10)
        {
            double s = (a+b+c)/2;
            double area = Math.Sqrt(s*((s - a)*(s - b)*(s - c)));
            Console.WriteLine(area);
        }
    }
}