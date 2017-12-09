using System;
using System.Linq;
using static System.Console;

class AnagramsEasy
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var strInput = ReadLine().Split(' ');
            if (strInput[0].Length != strInput[1].Length)
                WriteLine("False");
            else
            {
                var first = strInput[0].ToCharArray();
                var second = strInput[1].ToCharArray();
                Array.Sort(first);
                Array.Sort(second);
                WriteLine(Enumerable.SequenceEqual(first, second));
            }
        }
    }
}