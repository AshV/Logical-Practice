//https://www.hackerrank.com/contests/smart-interviews/challenges/si-implement-stack
using System;
using static System.Console;

class ImplementStack
{
    static int[] stack = new int[10000];
    static int top = -1;

    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        for (int t = 0; t < T; t++)
        {
            var str = ReadLine().Split(' ');
            if (str[0] == "push")
                push(int.Parse(str[1]));
            else
            {
                if (top == -1)
                    WriteLine("Empty");
                else
                    WriteLine(pop());
            }
        }
    }

    static int pop()
    {
        top -= 1;
        return stack[top + 1];
    }

    static void push(int e)
    {
        top += 1;
        stack[top] = e;
    }
}