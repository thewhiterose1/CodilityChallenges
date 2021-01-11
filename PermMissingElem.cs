using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // If empty array first one must be one
        if (A.Length == 0) return 1;
        Array.Sort(A);
        // If first value is not one, one must be missing
        if (A[0] != 1) return 1;

        // Checks all numbers between first element and last element
        for (int i = 0; i < A.Length - 1; i++) {
            if (A[i + 1] != A[i] + 1) return A[i] + 1; 
        }
        return A[A.Length - 1] + 1;
    }