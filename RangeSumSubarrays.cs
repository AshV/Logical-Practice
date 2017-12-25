using static System.Console;

class RangeSumSubarrays
{
    static void Main(string[] args)
    {
        int COUNT, SUM, N, A, B, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var str0 = ReadLine().Split(' ');
            var str1 = ReadLine().Split(' ');
            N = int.Parse(str0[0]);
            A = int.Parse(str0[1]);
            B = int.Parse(str0[2]);
            var intArr = new int[N];
            for (int a = 0; a < N; a++)
                intArr[a] = int.Parse(str1[a]);

            COUNT = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    SUM = 0;
                    for (int k = i; k <= j; k++)
                    {
                        SUM += intArr[k];
                    }
                    if (SUM >= A && SUM <= B)
                        COUNT++;
                }
            }
            WriteLine(COUNT);
        }
    }
}