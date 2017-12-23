using static System.Console;

class ReverseTheSentence
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var str = ReadLine().Trim().Split(' ');
            for (int p = str.Length - 1; p >= 0; p--)
                Write(str[p] + " ");
            WriteLine();
        }
    }
}