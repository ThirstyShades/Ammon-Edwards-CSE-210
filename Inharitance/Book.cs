public class Book : Loanable
{

    string _title; //place in Loanable
    string _isbn; // siral number
    int _upc; // wtf idk

    public Book(string title, string isbn, int upc)
    {
        _title = title;
        _isbn = isbn;
        _upc = upc; 
    }


    public override void Display()
    {
    Console.WriteLine($"Book Title: {_title}\nISBN: {_isbn}\nUPC: {_upc}");
    base.Display();
   
    }
}