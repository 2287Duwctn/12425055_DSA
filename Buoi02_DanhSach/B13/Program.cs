using System;
class Node
{
    public int Data;
    public Node Next;
    public Node(int data) { Data = data; }
}
class Program
{
    static Node ReverseList(Node head)
    {
        Node prev = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
    static void PrintList(Node head)
    {
        while (head != null)
        {
            Console.Write(head.Data + " -> ");
            head = head.Next;
        }
        Console.WriteLine("null");
    }
    static void Main()
    {
        Node head = new Node(1) { Next = new Node(2) { Next = new Node(3) { Next = new Node(4) } } };
        Console.Write("Ban đầu: ");
        PrintList(head);

        head = ReverseList(head);
        Console.Write("Đảo ngược: ");
        PrintList(head);
    }
}