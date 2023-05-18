using System;


public class Fraction
{
    // private by defalt
    int _topNum;
    int _botNum;

    public Fraction()
    {
        // defalt to 1/1 = 1
        _topNum = 1;
        _botNum = 1;

    }

    public Fraction(int topNum)
    {
        // User sets top
        _topNum = topNum;
        _botNum = 1;

    }

    public Fraction(int topNum, int botNum)
    {
        // User sets top
        _topNum = topNum;
        _botNum = botNum;
    }

public string GetFractionNotation()
{
    string frac = $"{_topNum}/{_botNum}";
    return frac;
}

// public int GetDeci()
// {
//     string deci = _topNum / _botNum;
//     return deci;
// }

 public double GetDecimalValue() // double == float??? IDK why the above code did not work. 
    {
        
        return (double)_topNum / (double)_botNum;
    }

}