using System;
class OrderNode
{
    public string OrderId;
    public string Status;
    public OrderNode Prev, Next;
    public OrderNode(string id)
    {
        OrderId = id;
        Status = "Chờ xử lý";
    }
    public void NextStatus()
    {
        if (Status == "Chờ xử lý") Status = "Đang giao";
        else if (Status == "Đang giao") Status = "Hoàn thành";
    }
    public void PrevStatus()
    {
        if (Status == "Hoàn thành") Status = "Đang giao";
        else if (Status == "Đang giao") Status = "Chờ xử lý";
    }
}
class OrderSystem
{
    private OrderNode head, tail;
    public void AddOrder(string id)
    {
        OrderNode newOrder = new OrderNode(id);
        if (head == null) head = tail = newOrder;
        else
        {
            tail.Next = newOrder;
            newOrder.Prev = tail;
            tail = newOrder;
        }
    }
    public OrderNode FindOrder(string id)
    {
        OrderNode temp = head;
        while (temp != null)
        {
            if (temp.OrderId == id) return temp;
            temp = temp.Next;
        }
        return null;
    }
    public void PrintAll()
    {
        OrderNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Đơn [{temp.OrderId}]: {temp.Status}");
            temp = temp.Next;
        }
    }
}
class Program
{
    static void Main()
    {
        OrderSystem sys = new OrderSystem();
        sys.AddOrder("DH01");
        sys.AddOrder("DH02");

        OrderNode dh1 = sys.FindOrder("DH01");
        dh1?.NextStatus();
        dh1?.NextStatus();
        dh1?.PrevStatus();

        sys.PrintAll();
    }
}