// https://www.hackerrank.com/contests/smart-interviews/challenges/si-check-power-of-two
using System;
using static System.Console;

class CheckPowerOfTwo
{
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(ReadLine());
        while (T > 0)
        {
            long N = Convert.ToInt64(ReadLine());
            WriteLine((N & (N - 1)) == 0 ? "True" : "False");
        }
    }
}