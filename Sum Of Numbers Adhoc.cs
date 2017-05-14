using System;
using static System.Console;

namespace LogicalProblems
{
    class Sum_Of_Numbers_Adhoc
    {
        static void Main(string[] args)
        {
            byte T = Convert.ToByte(ReadLine());
            long[] output = new long[T];
            for (byte b = 0; b < T; b++)
            {
                int N = Convert.ToInt32(ReadLine());
                output[b] = 0;
                string[] array = ReadLine().Split(' ');
                for (int i = 0; i < N; i++)
                    output[b] += Convert.ToInt64(array[i]);
            }

            for (int i = 0; i < T; i++)
                WriteLine(output[i]);
        }
    }
}