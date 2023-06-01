public class Dvd : Loanable // everything in Loanable is now included in Dvd. 
{

    private string _title; //placed in Loanable

    public Dvd(string title)
    {
        _title = title;
    }

    public override void Display()
    {
        Console.WriteLine($"DvD Title; {_title}");
        base.Display();
        
    }
}
