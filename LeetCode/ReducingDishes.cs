public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        
        int n = satisfaction.Length;
        Array.Sort(satisfaction);
        
        int previous = 0; 
        
        for (int pos = n - 1; pos >= 0; pos--) {
                int res = Recursion(satisfaction, n - 1, n - pos);
                if (res >= previous) {
                    previous = res; 
                }
                else return previous;
        }
        return previous;
    }
    
    public int Recursion(int[] satis, int pos, int mut) {
        if (mut == 1) {
            return satis[pos] * mut;
        }
        return (mut * satis[pos]) + Recursion(satis, pos - 1, mut - 1);
    }
}