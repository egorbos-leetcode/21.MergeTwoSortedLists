namespace Solution;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public ListNode(int[] array, int index = 0) : this(array.Length > index ? array[index] : 0, BuildNextNode(array, index + 1)) { }

    private static ListNode? BuildNextNode(int[] array, int index)
    {
        if (array.Length <= index) return null;
        return new ListNode(array[index], BuildNextNode(array, index + 1));
    }

    public int[] ToArray()
    {
        var list = new List<int>();
        var current = this;
        while (current is not null)
        {
            list.Add(current.val);
            current = current.next;
        }
        return [..list];
    }
}

public static class Solution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var root = new ListNode(-101); 
        var current = root;

        while (list1 is not null && list2 is not null) {
            if (list1.val <= list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        current.next = list1 is not null ? list1 : list2;

        return root.next;
    }
}
