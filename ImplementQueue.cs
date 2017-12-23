using static System.Console;

class ImplementQueue
{
    static int[] queue = new int[10000];
    static int f = -1, r = -1;
    static void Main(string[] args)
    {
        int T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var str = ReadLine().Trim().Split(' ');
            if (str[0] == "Enqueue")
                Enqueue(int.Parse(str[1]));
            else
            {
                if (f == r)
                    WriteLine("Empty");
                else
                    WriteLine(Dequeue());
            }
        }
    }

    public static void Enqueue(int e)
    {
        r++;
        queue[r] = e;
    }

    public static int Dequeue()
    {
        f++;
        return queue[f];
    }
}