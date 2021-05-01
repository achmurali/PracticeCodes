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
      ListNode dummy = new ListNode(0);
      dummy.next = head;
      int length = 0;
      ListNode ptr1 = head;
      while(ptr1 != null){
          length += 1;
          ptr1 = ptr1.next;
      }
      length = length - n;
      ptr1 = dummy;
      while(length > 0){
          length--;
          ptr1 = ptr1.next;
      }
      ptr1.next = ptr1.next.next;
      return dummy.next;
    }
}