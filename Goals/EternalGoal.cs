public class EternalGoal : Goal
{

    public EternalGoal() : base()
    {

    }



public override int RecordEvent()
{
    Console.WriteLine("Eternal Goal event recorded. These are never compleated!");
    Console.WriteLine($"Congradualtions you earned {_score} points!");
    return _score;

}

public override string Serialize() // this was for saving and loadign to a text file but I could not finish that
    {
        return $"EternalGoal:{_name},{_description},{_score}";
    }

    

}