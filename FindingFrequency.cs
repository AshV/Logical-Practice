// https://www.hackerrank.com/contests/smart-interviews/challenges/si-finding-frequency

using System;

class FindingFrequency
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var strArr = Console.ReadLine().Split(' ');
        var Arr = new int[N];
        for (int b = 0; b < N; b++)
            Arr[b] = int.Parse(strArr[b]);
        int X = 0, Count = 0, Q = int.Parse(Console.ReadLine());
        for (int i = 0; i < Q; i++)
        {
            Count = 0;
            X = int.Parse(Console.ReadLine());
            for (int j = 0; j < N; j++)
                if (X == Arr[j])
                    Count++;
            Console.WriteLine(Count);
        }
    }
}