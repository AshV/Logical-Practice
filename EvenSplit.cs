using System;
using static System.Console;

class EvenSplit
{
    static void Main()
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            long N = Int64.Parse(ReadLine());
            WriteLine(N < 4 || N % 2 != 0 ? "No" : "Yes");
        }
    }
}