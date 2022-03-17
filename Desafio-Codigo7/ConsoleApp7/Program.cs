using System;
class Problem
{
    static void Main(string[] args)
    {
        String[] input;
     
        input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int L = int.Parse(input[1]);

        if (N >= 3 && N <= 1000000 && L >= 1 && L <= 4000)
        {
            int P = N * L;
            Console.WriteLine(P);
        }
    }
}
