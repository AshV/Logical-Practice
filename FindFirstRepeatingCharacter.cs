using static System.Console;

class FindFirstRepeatingCharacter
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            string str = ReadLine();
            char firstChar = '.';
            bool flag = false;
            for (int i = 0; i < str.Length - 1; i++)
            {
                firstChar = str[i];
                flag = false;
                for (int j = i + 1; j < str.Length; j++)
                    if (firstChar == str[j])
                        flag = true;
                if (flag) break;
            }
            WriteLine(flag ? firstChar : '.');
        }
    }
}