using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] nArr = new int[N];
        int max = 0;

        for (int i = 0; i < A.Length; i++) {
            if (A[i] >= 1 && A[i] <= N) {
                nArr[A[i] - 1]++;
                if (nArr[A[i] - 1] > max) {
                    max = nArr[A[i] - 1];
                }
            }
            else if (A[i] == N + 1) {
                for (int x = 0; x < nArr.Length; x++) {
                    nArr[x] = max;
                }
            }
        }
        return nArr;
    }
}