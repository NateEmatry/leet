/*
    Leetcode problem 876

    Given the head of a singly linked list, return the middle node of the linked list.

    If there are two middle nodes, return the second middle node.
*/


// Definition for singly-linked list
public class ListNode {

    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null) {

        this.val = val;
        this.next = next;
    }


}


public static class MLLSolution {

    public static ListNode MiddleNode(ListNode head) {

        ListNode middle = head;

        while (head.next != null && middle.next != null)
        {
            if (head.next.next != null)
                head = head.next.next;

            else if (head.next != null)
                head = head.next;

            middle = middle.next;
        }

        if (middle == null)
            middle = head;

        return middle;
    }
}