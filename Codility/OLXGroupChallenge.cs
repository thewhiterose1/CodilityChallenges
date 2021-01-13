using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] juice, int[] capacity) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        Array.Sort(capacity, juice);

        int finalMax = 1;

        for (int lCap = capacity.Length - 1; lCap >= 0; lCap--) {
            int currMax = 1;
            int fill = juice[lCap];
            for (int sJuice = 0; sJuice < juice.Length; sJuice++) {
                if (capacity[lCap] >= juice[sJuice] + fill) {
                    currMax++;
                    fill = fill + juice[sJuice];
                    if (currMax > finalMax) finalMax++;
                }
                else break;
            }
        }
        return finalMax;
    }
}
