using System;
using System.Globalization;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Media;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = {0:F1}", Media, CultureInfo.InvariantCulture);
            Console.ReadKey();
        }
    }
}
