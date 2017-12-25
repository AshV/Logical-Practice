using System;
using System.Linq;
using static System.Console;

class FarewellParty
{
    static void Main(string[] args)
    {
        int N, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var count = new int[86400];
            N = int.Parse(ReadLine());
            for (int n = 0; n < N; n++)
            {
                var str = ReadLine().Split(' ');
                int inTime = int.Parse(str[0]);
                int outTime = int.Parse(str[1]);
                for (int f = inTime; f <= outTime; f++)
                    count[f] += 1;
            }
            WriteLine(count.Max());
        }
    }
}