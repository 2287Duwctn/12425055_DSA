using System;
class PageNode
{
    public string Url;
    public PageNode Prev, Next;
    public PageNode(string url) { Url = url; }
}
class BrowserHistory
{
    private PageNode current;

    public BrowserHistory(string homepage)
    {
        current = new PageNode(homepage);
    }
    public void Visit(string url)
    {
        PageNode newNode = new PageNode(url);
        current.Next = newNode;
        newNode.Prev = current;
        current = newNode;
        Console.WriteLine("Truy cập: " + current.Url);
    }
    public void Back()
    {
        if (current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back -> " + current.Url);
        }
        else Console.WriteLine("Không thể Back thêm!");
    }
    public void Forward()
    {
        if (current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward -> " + current.Url);
        }
        else Console.WriteLine("Không thể Forward thêm!");
    }
}
class Program
{
    static void Main()
    {
        BrowserHistory browser = new BrowserHistory("google.com");
        browser.Visit("youtube.com");
        browser.Visit("github.com");
        browser.Back();
        browser.Back();
        browser.Forward();
    }
}