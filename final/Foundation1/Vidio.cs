public class Vidio
{

    List<Comment> _comments = new List<Comment>();

    private string _title;
    private string _author;
    private int _vidioLength; // in seconds

    public Vidio(string title, string author, int vidioLength)
    {
        _title = title;
        _author = author;
        _vidioLength = vidioLength;

    }

    public void DisplayVidio()
    {
        Console.WriteLine("=============Vidio=============");
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nDeration (in seconds): {_vidioLength}");
    }

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void ListComments()
    {
        Console.WriteLine("=============Comments=============");
        foreach(Comment comment in _comments)
        {
        Console.WriteLine("----------------------------------");

            comment.DisplayComment();
        }                
        Console.WriteLine("----------------------------------");
    }


}