using System;
using static System.Console;

namespace LogicalProblems
{
    class Basic_Challenge_1
    {
        static void Main(string[] args)
        {
            byte T = Convert.ToByte(ReadLine());
            byte[] inp = new byte[T];
            for (byte i = 0; i < T; i++)
                inp[i] = Convert.ToByte(ReadLine());
            for (byte b = 1; b <= T; b++)
            {
                WriteLine(string.Format("Case #{0}:", b));
                byte N = inp[b - 1];
                for (byte i = 1; i <= N; i++)
                {
                    for (byte j = N; j > i; j--)
                        Write(' ');
                    for (byte k = 0; k < i; k++)
                        Write('*');
                    WriteLine();
                }
            }
        }
    }
}