using System;
using static System.Console;

class FindingCeil
{
    static void Main()
    {
        int Q, N = int.Parse(ReadLine());
        string[] strArr = ReadLine().Split(' ');
        int[] Arr = new int[N];
        for (int a = 0; a < N; a++)
            Arr[a] = int.Parse(strArr[a]);
        Array.Sort(Arr);
        Q = int.Parse(ReadLine());
        for (int q = 0; q < Q; q++)
        {
            int location = NearestElement(Arr, int.Parse(ReadLine()));
            WriteLine(location > N - 1 ? int.MaxValue : Arr[location]);
        }
    }

    static int NearestElement(int[] data, int searchElement)
    {
        int low = 0;
        int high = data.Length - 1;
        int middle = (low + high + 1) / 2;
        int location = -1;
        do
        {
            if (searchElement == data[middle])
                location = middle;
            else if (searchElement < data[middle])
                high = middle - 1;
            else
                low = middle + 1;

            middle = (low + high + 1) / 2;
        } while ((low <= high) && (location == -1));

        return middle;
    }
}