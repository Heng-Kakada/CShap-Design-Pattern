namespace Adapter;

 public class BookAdapter : Book, IInfo
{
    public BookAdapter(string title, int pages, string author)
        : base(title, pages, author)
    {
    }
    public string Text
    {
        get
        {
            return string.Format("Title={0}, Pages={1:N0}, Author={2}",
                base.Title, base.Pages, base.Author);
        }
    }
    public string Type
    {
        get
        {
            return "Book";
        }
    }
}
