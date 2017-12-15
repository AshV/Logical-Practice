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
            int a = 0, temp = 0, N = Convert.ToInt32(ReadLine());
            int[] arr = new int[N + 1];
            string[] arrStr = ReadLine().Split(' ');

            for (a = 0; a < N; a++)
            {
                temp = int.Parse(arrStr[a]);
                arr[temp - 1] = temp;
            }

            for (a = 0; a < N; a++)
            {
                if (arr[a] != a + 1)
                    WriteLine(a + 1);
            }
        }
    }
}