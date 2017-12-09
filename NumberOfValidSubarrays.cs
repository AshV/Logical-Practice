using static System.Console;

class NumberOfValidSubarrays
{
    static void Main(string[] args)
    {
        int Zero, One, Count, N, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            N = int.Parse(ReadLine());
            var Arr = ReadLine().Split(' ');
            Count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i; j < N; j++)
                {
                    Zero = 0;
                    One = 0;
                    for (int k = i; k <= j; k++)
                    {
                        if (Arr[k] == "0")
                            Zero++;
                        else
                            One++;
                    }
                    if (Zero == One)
                        Count++;
                }
            }
            WriteLine(Count);
        }
    }
}