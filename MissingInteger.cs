using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        SortedSet<int> B = new SortedSet<int>();
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        foreach(int i in A) {
            if(i > 0) {
                B.Add(i);
            }
        }

        int lowestInt = 0;
        while(lowestInt < B.Count) {
            lowestInt ++;
            if(!B.Contains(lowestInt)) {
                return lowestInt;
            }
        }
        return B.Max + 1;
    }
}