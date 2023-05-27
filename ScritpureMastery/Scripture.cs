public class Scripture
{
    /// attributes
    ///And it came to pass that the people of Limhi began to drive the Lamanites before them; yet they were not half so numerous as the Lamanites. But they fought for their lives, and for their wives, and for their children; therefore they exerted themselves and like dragons did they fight.
   List<Word> _words = new List<Word>();
   
    string _scripture;
    Referance _referance;

    public Scripture (Referance referance, string scripture = "And it came to pass that the people of Limhi began to drive the Lamanites before them; yet they were not half so numerous as the Lamanites. But they fought for their lives, and for their wives, and for their children; therefore they exerted themselves and like dragons did they fight.")
    {
      _referance = referance; 

      _scripture = scripture; 
    }

    public void SplitText()
    {
        foreach(string part in _scripture.Split(" "))
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    
    public void DisplayScripture()
    {
        foreach(Word word in _words)
        {
            Console.Write($"{word.DisplayWord()} "); // arturatlate 
        }
    }
    
    public int RandomWordGen()
    {
        Random numGen = new Random(); 
        int ranNum = numGen.Next(0,_words.Count);
        return ranNum; 
    }

    public void HideWord()
    {

        _words[RandomWordGen()].HideWord();

    }

        public void ShowWord()
    {
        
        _words[RandomWordGen()].ShowWord();

    }

    // store indexes in a different list and write  if statment to check

    // conttains (list look up)

}