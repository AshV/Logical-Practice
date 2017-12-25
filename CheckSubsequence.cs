using static System.Console;

class CheckSubsequence
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for(int t = 0; t < T; t++)
        {
            var str = ReadLine().Trim().Split(' ');
            WriteLine(FoundInSequence(str[0], str[1], str[0].Length, str[1].Length) ? "Yes" : "No");
        }
    }

    static bool FoundInSequence(string str1, string str2, int str1Length, int str2Length)
    {
        if (str1Length == 0) return true;
        if (str2Length == 0) return false;

        if (str1[str1Length - 1] == str2[str2Length - 1])
            return FoundInSequence(str1, str2, str1Length - 1, str2Length - 1);

        return FoundInSequence(str1, str2, str1Length, str2Length - 1);
    }
}