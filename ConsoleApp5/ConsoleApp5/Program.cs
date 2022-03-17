using System;

class TESTE
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        if (A >= 1 && A <= 40 && B >= 1 && B <= 40)
        {
            int C = A - B;
            Console.WriteLine(C);
        }


    }
}