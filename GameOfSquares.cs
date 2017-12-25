using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GameOfSquares
{
    static void Main(string[] args)
    {
        int N, T = int.Parse(ReadLine());
        bool flag = true;
        for (int t = 0; t < T; t++)
        {
            N = int.Parse(ReadLine());
            flag = true;
            while (N >= 0)
            {
                if (flag)
                {
                    --N;
                    flag = false;
                }
                else
                {
                    --N;
                    flag = true;
                }
            }
            Console.WriteLine(flag);
        }
    }
}