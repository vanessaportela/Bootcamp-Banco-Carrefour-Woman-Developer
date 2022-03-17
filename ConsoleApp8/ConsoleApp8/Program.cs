using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int inicio = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(inicio + " " + Math.Pow(inicio,2) + " " +  Math.Pow(inicio,3));
                inicio++;
            }
        }
    }
}
