using System.Collections.Generic;
using static System.Console;

class DistinctElementsInWindow
{
    static void Main(string[] args)
    {
        int N, K, T = int.Parse(ReadLine());
        for (int i = 0; i < T; i++)
        {
            var strInput1 = ReadLine().Split(' ');
            N = int.Parse(strInput1[0]);
            K = int.Parse(strInput1[1]);

            var strInput2 = ReadLine().Split(' ');
            for (int n = 0; n < N-K+1; n++)
            {
                var distinct = new HashSet<string>();
                for (int k = n; k < n + K; k++)
                    distinct.Add(strInput2[k]);
                Write(distinct.Count + " ");
            }
            WriteLine();
        }
    }
}