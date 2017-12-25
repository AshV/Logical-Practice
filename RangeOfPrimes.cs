using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RangeOfPrimes
{
    static void Main(string[] args)
    {
        int Count, A, B, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            Count = 0;
            var str = ReadLine().Split(' ');
            A = int.Parse(str[0]);
            B = int.Parse(str[1]);
            for (int r = A; r <= B; r++)
            {
                if (IsPrime(r)) Count++;
            }
            WriteLine(Count);
        }
    }

    static bool IsPrime(int candidate)
    {
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        for (int i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}