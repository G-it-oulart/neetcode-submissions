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
    public void ReorderList(ListNode head) {
        ListNode originalLeft = head;
        ListNode left = head;
        ListNode right = head;
        while(right!=null && right.next!=null){
            left = left.next;
            right = right.next.next;
        }
        ListNode rightPartition = ReverseList(left.next);
        left.next=null;
        ReorderPartitions(originalLeft,rightPartition);
    }

    public ListNode ReverseList(ListNode head){
        if(head==null || head.next == null){
            return head;
        }
        ListNode newHead = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return newHead;
    }

    public void ReorderPartitions(ListNode leftPartition, ListNode rightPartition){
        if(rightPartition==null){
            return;
        }
        ListNode newRight = leftPartition.next;
        leftPartition.next = rightPartition;
        ReorderPartitions(rightPartition,newRight);
    }
}
