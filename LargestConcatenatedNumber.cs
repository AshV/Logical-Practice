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
            Array.Sort(strInput, (a, b) =>
            {
                string ab = a + b;
                string ba = b + a;
                return ba.CompareTo(ab);
            });
            WriteLine(string.Join("", strInput));
        }
    }
}