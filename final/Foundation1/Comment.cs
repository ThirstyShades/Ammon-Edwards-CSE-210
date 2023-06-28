public class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _text = text;
        _author = author;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Author: {_author}.\nComment: {_text}"
        );
    }
}




