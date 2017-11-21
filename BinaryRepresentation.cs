// https://www.hackerrank.com/contests/smart-interviews/challenges/si-binary-representation
using System;
using static System.Console;

class BinaryRepresentation
{
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(ReadLine());
        while (T > 0)
        {
            T--;
            WriteLine(Convert.ToString(Convert.ToInt64(ReadLine()), 2));
        }
    }
}