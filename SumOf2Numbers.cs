using System.Linq;
using static System.Console;

class SumOf2Numbers
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(ReadLine());
            string[] strArray = ReadLine().Split(' ');
            int[] Arr = new int[N];
            for (int a = 0; a < N; a++)
                Arr[a] = int.Parse(strArray[a]);

            bool flag = false;
            int wholeSum = Arr.Sum();
            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    if ((Arr[i] + Arr[j]) == (wholeSum - Arr[i] - Arr[j]))
                    {
                        flag = true;
                        break;
                    }
            WriteLine(flag ? "Yes" : "No");
        }
    }
}