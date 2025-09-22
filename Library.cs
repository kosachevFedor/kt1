using System.Collections.Generic;

class Library : Building
{
    private List<string> _books;

    public Library(string address) : base(address)
    {
        _books = new List<string>();
    }

    public List<string> Books { get { return _books; } }

    public void AddBook(string bookTitle)
    {
        _books.Add(bookTitle);
    }

    public bool HasBook(string bookTitle)
    {
        return _books.Contains(bookTitle);
    }
}

