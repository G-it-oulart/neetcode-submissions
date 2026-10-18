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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode left = new ListNode(0,head);
        ListNode leftPrevious = new ListNode(0,left);
        ListNode right = head;
        for(int i =1;i<n;i++){
            right=right.next;
        }
        while(right!=null){
            leftPrevious=leftPrevious.next;
            left=left.next;
            right=right.next;
        }
        leftPrevious.next = left.next;
        if(left == head){
            return head.next;
        }
        return head;
    }
}