using System;
class Node
{
    public int Data;
    public Node Next;
    public Node(int data) { Data = data; }
}
class Program
{
    static bool HasCycle(Node head)
    {
        Node slow = head;
        Node fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
                return true;
        }
        return false;
    }
    static void Main()
    {
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);
        Node n5 = new Node(5);
        Node n6 = new Node(6);

        n2.Next = n3; n3.Next = n4; n4.Next = n5; n5.Next = n6; n6.Next = n2;

        Console.WriteLine("Có chu trình không? " + HasCycle(n2));
    }
}