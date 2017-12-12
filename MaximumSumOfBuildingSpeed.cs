// https://www.hackerearth.com/challenge/hiring/practo-developer-hiring-challenge/algorithm/maximum-sum-of-building-speed-00ab8996/

using System;
using static System.Console;

class MaximumSumOfBuildingSpeed
{
    static void Main(string[] args)
    {
        int N = int.Parse(ReadLine());
        var strArr = ReadLine().Trim().Split(' ');
        var intArr = new int[2 * N];
        for (int a = 0; a < 2 * N; a++)
            intArr[a] = int.Parse(strArr[a]);
        Array.Sort(intArr);
        int count = 0;
        for (int i = 0; i < 2 * N; i+=2)
        {
            count += intArr[i];
        }
        WriteLine(count);
    }
}