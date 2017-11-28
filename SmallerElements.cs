using System;
class SmallerElements
{
    static void Main()
    {
        int Output, T = Convert.ToInt32(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var strArr = Console.ReadLine().Split(' ');
            var Arr = new int[N];
            for (int a = 0; a < N; a++)
                Arr[a] = Convert.ToInt32(strArr[a]);

            Output = 0;
            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    if (Arr[i] > Arr[j])
                        Output++;
            Console.WriteLine(Output);
        }
    }
}