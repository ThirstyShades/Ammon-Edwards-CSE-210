using System;

public class Word
{
    //Attributes
    string _word;
    bool _isShown = true; 

    public Word(string word)
    {
        _word = word;
    }

    public string DisplayWord()
    {
        string dashes = _word; 
        switch(_isShown)
        {
            case true:
            break;

            case false:
            int stringLength = _word.Length;
            foreach(char i in _word)
            {
                dashes = dashes.Replace(i,char.Parse("-"));
            }
            break;
            
        }
        return dashes; 
    }
 

    
    public void HideWord()
    {
        _isShown = false;
    }

    public void ShowWord()
    {
        _isShown = true;
    }
    



}