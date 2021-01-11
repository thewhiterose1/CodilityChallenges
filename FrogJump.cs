using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        double x = X;
        double y = Y;
        double d = D;

        return (int) Math.Ceiling((y - x) / d);
    }
}