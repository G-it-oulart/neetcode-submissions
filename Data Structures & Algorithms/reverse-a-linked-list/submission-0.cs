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
    public ListNode ReverseList(ListNode head) {
        return AssignPrevious(head);
    }

    public static ListNode AssignPrevious(ListNode head) {
        if(head==null){
            return head;
        }
        if (head.next == null) {
            return head;
        } else {
            ListNode newHead = AssignPrevious(head.next);
            ListNode next = head.next;
            next.next = head;
            head.next = null;
            return newHead;
        }
    }
}
