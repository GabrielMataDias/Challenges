// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

// Constraints:

// The number of nodes in the list is in the range [1, 105].
// 0 <= Node.val <= 9

bool IsPalindrome(ListNode head)
{
    {
        List<int> sequence = new List<int>();

        for (ListNode node = head; node != null; node = node.next)
        {
            sequence.Add(node.val);
        }

        if (sequence.Count <= 1)
        {
            return true;
        }

        for (int i = 0; i < sequence.Count / 2; i++)
        {
            if (sequence[i] != sequence[sequence.Count - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}