public class Book
{
    public string _title = "";
    public string _author = "";
    public int _pageCount = 0;

    public string getSummary()
    {
        return $"{_title} by {_author}, {_pageCount} pages";
    }
}