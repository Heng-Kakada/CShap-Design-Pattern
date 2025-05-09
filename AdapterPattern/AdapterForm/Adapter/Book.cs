namespace Adapter;

public class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
    public string Author { get; set; }
    public Book(string title, int pages, string author)
    {
        this.Title = title;
        this.Pages = pages;
        this.Author = author;
    }
    public Book() : this("", 0, "")
    {
    }
}
