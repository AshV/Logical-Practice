// https://www.hackerrank.com/contests/smart-interviews/challenges/si-distinct-elements-in-window/problem

using System.Collections.Generic;
using static System.Console;

class DistinctElementsInWindow
{
    static void Main(string[] args)
    {
        int N, K, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var strInput1 = ReadLine().Split(' ');
            N = int.Parse(strInput1[0]);
            K = int.Parse(strInput1[1]);
            var strInput2 = ReadLine().Trim().Split(' ');
            var distinct = new Dictionary<string, int>();

            for (int k = 0; k < K; k++)
                Add(strInput2[k], ref distinct);
            Write(distinct.Count + " ");

            for (int i = 1; i < N - K + 1; i++)
            {
                Remove(strInput2[i-1], ref distinct);
                Add(strInput2[i + K-1], ref distinct);

                Write(distinct.Count + " ");
            }
            WriteLine();
        }
    }

    static void Add(string key, ref Dictionary<string, int> distinct)
    {
        int value;
        if (distinct.TryGetValue(key, out value))
            distinct[key] = value + 1;
        else
            distinct.Add(key, 1);
    }

    static void Remove(string key, ref Dictionary<string, int> distinct)
    {
        int value;
        if (distinct.TryGetValue(key, out value))
        {
            if (value == 1)
                distinct.Remove(key);
            else
                distinct[key] = value - 1;
        }
    }
}