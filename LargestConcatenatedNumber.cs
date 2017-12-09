using System;
using static System.Console;

class LargestConcatenatedNumber
{
    static void Main(string[] args)
    {

        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            ReadLine();
            string[] strInput = ReadLine().Split(' ');
            Array.Sort(strInput, (i, j) => j.CompareTo(i));
            WriteLine(string.Join("", strInput));
        }
    }
}