using System;
using static System.Console;

class AddReversedNumbers
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            string[] strInput = ReadLine().Split(' ');
            WriteLine(Int64.Parse(ReverseString(strInput[0])) + Int64.Parse(ReverseString(strInput[1])));
        }
    }

    static string ReverseString(string str)
    {
        string rev = "";
        for (int i = str.Length - 1; i > -1; i--)
            rev += str[i];
        return rev;
    }
}