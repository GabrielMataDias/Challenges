// Given the head of a singly linked list, return the middle node of the linked list.

// If there are two middle nodes, return the second middle node.

// Constraints:

// The number of nodes in the list is in the range [1, 100].
// 1 <= Node.val <= 100

public ListNode MiddleNode(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }

    return slow;
}