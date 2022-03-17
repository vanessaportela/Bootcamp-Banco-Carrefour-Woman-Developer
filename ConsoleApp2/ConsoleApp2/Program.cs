using System;
using System.Globalization;

class minhaClasse
{
    static void Main(string[] args)
    {
        double a, b, c, delta, r1, r2;
        string[] valor = Console.ReadLine().Split(' ');

        a = Convert.ToDouble(valor[0]);
        b = Convert.ToDouble(valor[1]);
        c = Convert.ToDouble(valor[2]);

        delta = (Math.Pow(b, 2) - (4 * a * c));

        if (a == 0.0 || delta < 0.0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}