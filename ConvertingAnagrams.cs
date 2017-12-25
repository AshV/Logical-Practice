using System;
using static System.Console;

class ConvertingAnagrams
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var str = ReadLine().Split();
            var count1 = new int[26];
            var count2 = new int[26];

            for (int i = 0; i < str[0].Length; i++)
            {
                count1[str[0][i] - 'a']++;
            }
            for (int i = 0; i < str[1].Length; i++)
            {
                count2[str[1][i] - 'a']++;
            }
            int result = 0;
            for (int i = 0; i < 26; i++)
            {
                result += Math.Abs(count1[i] - count2[i]);
            }
            WriteLine(result);
        }
    }
}