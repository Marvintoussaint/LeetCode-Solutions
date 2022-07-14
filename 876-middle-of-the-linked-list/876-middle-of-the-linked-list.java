/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode middleNode(ListNode head) {
         
        ListNode a_pointer = head;
        ListNode b_pointer = head;
        
        int counter = 0;
        
        int mid = 0;

        // get length of the linked list
        
        while(a_pointer != null)
        {
            counter++;
            
            a_pointer = a_pointer.next;
        }
        
       
        mid = counter / 2 ;
        
        for(int i = 0; i < mid ; i++)
        {
            b_pointer = b_pointer.next;
        }
        
        
        return b_pointer;    
}
    
    
}