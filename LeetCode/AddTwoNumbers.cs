/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        // Calculate the integer sum of l1 and l2
        String fSum = (BigInteger.Parse(Recursive(l1)) + BigInteger.Parse(Recursive(l2))).ToString();
        
        // Generate the new linked list
        ListNode previous = new ListNode(Int32.Parse(fSum[0].ToString()), null);
        for (int i = 1; i < fSum.Length; i++) {
            previous = new ListNode(Int32.Parse(fSum[i].ToString()), previous); 
        }
        
        return previous;
    }
    
    // Returns a string of a reversed input LinkedList
    public String Recursive(ListNode currNode) {
        if (currNode.next == null) {
            return currNode.val.ToString(); 
        }
        return Recursive(currNode.next) + currNode.val.ToString();
    }
}