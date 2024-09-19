using System;

namespace PS_03_Area
{
    class Program
    {
        public static void Main(string[] args)
        {
            Leap_Year();
        }

        public static void Leap_Year()
        {
            int year = 2025;

            if ((year % 4 == 0) && !(year % 100 == 0) && !(year % 400 == 0)){
                Console.WriteLine($"{year} is a leap year");
            }else{
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}