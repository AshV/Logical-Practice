using static System.Console;

class PrintDiamondPattern
{
    static void Main(string[] args)
    {
        int N = int.Parse(ReadLine());
        for(int i=0;i<N;i++)
        {
            for (int j = i; j < (N/2); j++)
                Write("0");
            WriteLine();

        }
    }
}