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
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        if(fast==null){
            return false;
        }
        while(fast != null){
            slow = slow.next;
            fast = fast.next;
            if(fast!=null){
                fast = fast.next;
            } else{
                return false;
            }
            if(fast==slow){
                return true;
            }
        }
        return false;
    }
}
