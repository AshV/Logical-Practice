using System;
using static System.Console;

class RoboticExhibition
{
    static void Main(string[] args)
    {
        int N, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            N = int.Parse(ReadLine());
            var str = ReadLine().Split(' ');
            var intArr = new int[N];
            for (int a = 0; a < N; a++)
                intArr[a] = int.Parse(str[a]);
            Array.Sort(intArr);
            WriteLine(MissingCombination(intArr, N));
        }
    }

    static int MissingCombination(int[] arr, int n)
    {
        int res = 1;
        for (int i = 0; i < n && arr[i] <= res; i++)
            res = res + arr[i];
        return res;
    }
}