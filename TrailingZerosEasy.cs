using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

class TrailingZerosEasy
{
    static void Main(string[] args)
    {
        long N = 99999999999999, Fact = 1; ;
        while (N > 0)
        {
            Fact *= N;
            N--;
        }
        WriteLine(Fact);
    }

    static long Fact(long N)
    {
        if (N == 1)
            return N;
        return Fact(N - 1) * N;
    }
}