using System;
class SongNode
{
    public string Title;
    public SongNode Prev, Next;
    public SongNode(string title) { Title = title; }
}
class Playlist
{
    private SongNode head, tail, current;

    public void AddSong(string title)
    {
        SongNode newNode = new SongNode(title);
        if (head == null)
        {
            head = tail = current = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }
    public void RemoveCurrent()
    {
        if (current == null) return;
        Console.WriteLine("Đã xóa: " + current.Title);

        if (current.Prev != null) current.Prev.Next = current.Next;
        else head = current.Next;

        if (current.Next != null) current.Next.Prev = current.Prev;
        else tail = current.Prev;

        current = (current.Next != null) ? current.Next : current.Prev;
    }
    public void NextSong()
    {
        if (current != null && current.Next != null)
            current = current.Next;
        ShowCurrent();
    }
    public void PrevSong()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
        ShowCurrent();
    }
    public void ShowCurrent()
    {
        Console.WriteLine("Đang phát: " + (current != null ? current.Title : "Trống"));
    }
}
class Program
{
    static void Main()
    {
        Playlist pl = new Playlist();
        pl.AddSong("Bài 1 - Lạc Trôi");
        pl.AddSong("Bài 2 - Nơi Này Có Anh");
        pl.AddSong("Bài 3 - Cắt Đôi Nỗi Sầu");

        pl.ShowCurrent();
        pl.NextSong();
        pl.RemoveCurrent();
        pl.ShowCurrent();
    }
}