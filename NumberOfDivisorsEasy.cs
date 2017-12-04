using System;
using static System.Console;

class NumberOfDivisorsEasy
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        long Loop, Count, N;
        for (int t = 0; t < T; t++)
        {
            N = Int64.Parse(ReadLine());
            if (N % 2 == 0)
                Count = 3;
            else
                Count = 2;
            for (long i = 2; i < N / 2; i++)
                if (N % i == 0)
                    Count++;
            WriteLine(Count);
        }
    }
}