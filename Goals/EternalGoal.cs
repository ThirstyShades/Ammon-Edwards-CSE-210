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
}