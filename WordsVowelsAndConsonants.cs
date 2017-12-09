using System.Text.RegularExpressions;
using static System.Console;

class WordsVowelsAndConsonants
{
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            int Word = 0, Vowel = 0, Consonant = 0;
            var words = Regex.Replace(ReadLine().Trim().ToUpper(), @"\s+", " ").Split(' ');
            Word = words.Length;
            for (int w = 0; w < Word; w++)
            {
                for (int c = 0; c < words[w].Length; c++)
                    switch (words[w][c])
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            Vowel++;
                            break;
                        default:
                            Consonant++;
                            break;
                    }
            }
            WriteLine($"{Word} {Vowel} {Consonant}");
        }
    }
}