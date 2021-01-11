using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        int max =
        (from item in A.Concat(B).ToArray()
                group item by item into g
                orderby g.Count() descending
                select g.Key).First();

        int maxRect = 0;

        for (int i = 0; i < A.Length; i++) {
            if (A[i] == max || B[i] == max) {
                maxRect++;
            }
        }
        return maxRect;
    }
}