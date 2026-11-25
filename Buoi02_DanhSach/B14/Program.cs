using System;
class Node
{
    public int Data;
    public Node Next;
    public Node(int data) { Data = data; }
}
class Program
{
    static Node MergeSortedLists(Node l1, Node l2)
    {
        Node dummy = new Node(0);
        Node tail = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.Data <= l2.Data)
            {
                tail.Next = l1;
                l1 = l1.Next;
            }
            else
            {
                tail.Next = l2;
                l2 = l2.Next;
            }
            tail = tail.Next;
        }
        tail.Next = (l1 != null) ? l1 : l2;
        return dummy.Next;
    }
    static void Main()
    {
        Node l1 = new Node(1) { Next = new Node(3) { Next = new Node(5) } };
        Node l2 = new Node(2) { Next = new Node(4) { Next = new Node(6) } };

        Node merged = MergeSortedLists(l1, l2);
        while (merged != null)
        {
            Console.Write(merged.Data + " -> ");
            merged = merged.Next;
        }
        Console.WriteLine("null");
    }
}