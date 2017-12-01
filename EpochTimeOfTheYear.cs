// https://www.hackerrank.com/contests/smart-interviews/challenges/si-time-of-the-year

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class EpochTimeOfTheYear
{
    static void Main(string[] args)
    {
        var T = int.Parse(ReadLine());
        for (var t = 0; t < T; t++)
        {
            var S = Int64.Parse(ReadLine());
            var D = S / 60 / 60 / 24;
            var Y = D / 365;
        }
    }
}