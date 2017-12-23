using System.Collections.Generic;
using System.Linq;
using static System.Console;

class CollectingMangoes
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();
        var max = new Stack<int>();
        int N = 0, temp = 0, T = int.Parse(ReadLine());
        for (int t = 0; t < T; t++)
        {
            stack.Clear();
            max.Clear();
            max.Push(0);
            N = int.Parse(ReadLine());
            WriteLine($"Case {t + 1}:");
            for (int n = 0; n < N; n++)
            {
                var str = ReadLine().Trim().Split(' ');
                switch (str[0])
                {
                    case "A":
                        temp = int.Parse(str[1]);
                        stack.Push(temp);
                        if (max.Peek() < temp)
                            max.Push(temp);
                        break;
                    case "R":
                        if (stack.Count > 0)
                        {
                            temp = stack.Pop();
                            if (max.Peek() == temp)
                                max.Pop();
                        }
                        break;
                    case "Q":
                        if (stack.Count > 0)
                            WriteLine(max.Peek());
                        else
                            WriteLine("Empty");
                        break;
                }
            }
        }
    }
}