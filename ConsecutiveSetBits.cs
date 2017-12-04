using System;
using static System.Console;

class ConsecutiveSetBits
{
    static void Main(string[] args)
    {
        int count, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            long x = Int64.Parse(ReadLine());
            count = 0;
            while (x != 0)
            {
                x = (x & (x << 1));
                count++;
            }
            WriteLine(count);
        }
    }
}