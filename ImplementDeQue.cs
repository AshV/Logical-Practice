using static System.Console;

class ImplementDeQue
{
    static int[] deQue = new int[10000];
    static int f = 5001, r = 5000;
    static void Main(string[] args)
    {
        var T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            var str = ReadLine().Split(' ');
            switch (str[0])
            {
                case "push_front":
                    push_front(int.Parse(str[1]));
                    break;
                case "push_back":
                    push_back(int.Parse(str[1]));
                    break;
                case "pop_front":
                    if (f == r)
                        WriteLine("Empty");
                    else
                        WriteLine(pop_front());
                    break;
                case "pop_back":
                    if (f == r)
                        WriteLine("Empty");
                    else
                        WriteLine(pop_back());
                    break;
            }
        }
    }

    static void push_front(int e)
    {
        f--;
        deQue[f] = e;
    }
    static void push_back(int e)
    {
        r++;
        deQue[r] = e;
    }
    static int pop_front()
    {
        f++;
        return deQue[f - 1];
    }
    static int pop_back()
    {
        r--;
        return deQue[r + 1];
    }
}