// https://www.hackerrank.com/contests/smart-interviews/challenges/si-distinct-elements-in-window/problem

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
            for (int n = 0; n < N - K + 1; n++)
            {
                var distinct = new Dictionary<int, int>();
                for (int k = n; k < n + K; k++)
                {
                    int value;
                    if (distinct.TryGetValue(int.Parse(strInput2[k]), out value))
                        distinct.Add(int.Parse(strInput2[k]), value + 1);
                    else
                        distinct.Add(int.Parse(strInput2[k]), 1);
                }
                Write(distinct.Count + " ");
            }
            WriteLine();
        }
    }
}