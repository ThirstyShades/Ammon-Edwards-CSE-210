public class ChecklistGoal : Goal
{
    private int _actsNeeded; 
    private int _actsRecorded;
    private int _bonuseScore;
    

    public ChecklistGoal() : base()
    {
        Console.WriteLine("Enter the score that you will get by partialy compleating this goal:");
        _bonuseScore
         = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of times this goal needs to be done, before it is fully compleate:");
        _actsNeeded = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
{
    Console.WriteLine("Checklist Goal event recorded.");
    if(_actsRecorded +1 > _actsNeeded)
    {
        Console.WriteLine("This goal has allready been compleated!");
        return 0;
    }
    else if(_isCompleted == false && _actsRecorded +1 != _actsNeeded) 
    {
        Console.WriteLine($"You are one step closer to compleating your goal! You earned {_bonuseScore} points!");
        _actsRecorded += 1;
        return _bonuseScore;
        
    }
    else if(_isCompleted == false && _actsRecorded +1 == _actsNeeded)
    {
        Console.WriteLine($"Congraloations! you compleated your goal!\nYou reseved {_bonuseScore} + {_score} for a total of {_score + _bonuseScore} points!");
        _actsRecorded += 1;
        _isCompleted = true;
        return _score + _bonuseScore;
    }
    else
    {
        Console.WriteLine("How did you get here? stop enterying negitive numbers mabye? I don't know what else would cause you get see this but good job?");
        return 0;
    }
}

public override void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} ({_description}) | score: {_score} | | update score: {_bonuseScore} | currently compleated: {_actsRecorded}/{_actsNeeded}");
    }

}