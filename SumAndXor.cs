using System;
using static System.Console;

class SumAndXor
{
    static void Main(string[] args)
    {
        int Count,T = int.Parse(ReadLine());
        long N;
        for (int t = 0; t < T; t++)
        {
            Count = 0;
            N = Int64.Parse(ReadLine());
            for (int i = 1; i < N; i++)
                if ((N + i) == (N ^ i))
                    Count++;
            WriteLine(Count);
        }
    }
}