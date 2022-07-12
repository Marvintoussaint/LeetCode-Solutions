/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public boolean hasCycle(ListNode head) {
                
		// base case
		if(head == null || head.next == null)
		{
			return false;
		}
		
		// define pointer
		
		ListNode slow = head;
		
		ListNode fast = head;
		
		// traverse the list to see if there is a cycle
		
		while(fast != null && fast.next != null) // if fast pointer reaches null then there is no cycle
		{
			fast = fast.next.next; // the fast pointer is moving two nodes at a times
			slow = slow.next;
			if(slow == fast )
			{
				return true;
			}
		}
		
		// return false if there is no cycle
		
		return false;
    }
}