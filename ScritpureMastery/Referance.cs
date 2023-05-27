public class Referance
{
    // Attriburtes
    string _book;
    int _startVerse;
    int _endVerse;
    int _chapter;


    public Referance(string book, int startVerse, int endVerse, int chapter)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse; 
        _chapter = chapter; 
    }
        public Referance(string book, int startVerse, int chapter)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = 0; 
        _chapter = chapter; 
    }


    public void DisplayReferance()
    {
        switch(_endVerse)
        {
            case 0:
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
            break;
            case >0:
            Console.Write($"{_book} {_chapter};{_startVerse}-{_endVerse} ");
            break;
        }
    }


}