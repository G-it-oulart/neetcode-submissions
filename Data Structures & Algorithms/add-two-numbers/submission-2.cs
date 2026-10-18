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
        ListNode newHead = new ListNode(0,null);
        ListNode head = newHead;
        int carry = 0;
        int sum = 0;
        while (l1 != null || l2!= null) {
            if(l1==null){
                sum = l2.val+carry;
                l2 = l2.next;
            }
            else if(l2==null){
                sum = l1.val+carry;
                l1 = l1.next;
            } else{
                sum = (l1.val + l2.val + carry);
                l1 = l1.next;
                l2 = l2.next;
            } 
            newHead.val = sum % 10;
            carry = sum / 10;
            if(l1!=null || l2!= null || carry>0 ){
                newHead.next = new ListNode(0,null);
                newHead = newHead.next;
            }
        }
        if(carry>0){
            newHead.val = carry;
        }
        return head;
    }
}