// https://www.hackerrank.com/contests/smart-interviews/challenges/si-finding-missing-number/submissions/code/1304219607
using static System.Console;
using System;

class FindingMissingNumber
{
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(ReadLine());
        while (T > 0)
        {
            int temp = 0, N = Convert.ToInt32(ReadLine());
            int[] arr = new int[N];
            string[] arrStr = ReadLine().Split(' ');

            for (int a = 0; a < N; a++)
                arr[a] = Convert.ToInt32(arrStr[a]);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

            for (int c = 0; c < N; c++)
                if (c + 1 != arr[c])
                {
                    WriteLine(c + 1);
                    break;
                }
        }
    }
}