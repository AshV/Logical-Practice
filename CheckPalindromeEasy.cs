using static System.Console;

class CheckPalindromeEasy
{
    static void Main(string[] args)
    {
        int N, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            N = int.Parse(ReadLine());
            string str = ReadLine();
            bool flag = true;
            for (int i = 0, j = N - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
            }
            WriteLine(flag ? "Yes" : "No");
        }
    }
}