public class SimpleGoal : Goal
{
    
// all needed attributes have been inharited from the bass class along with the constuctor information.

    public SimpleGoal() : base()
        {

        }



    public override int RecordEvent()
    {
        Console.WriteLine("Simple Goal event recorded.");
        if(_isCompleted == false)
        {
            _isCompleted = true;
            Console.WriteLine($"Congradualtions you earned {_score} points!");
            return _score;
        }
        else
        {
            Console.WriteLine("That goal has allready been compleated!");
            return 0;
        }
    }
    public override string Serialize() // this was for saving and loadign to a text file but I could not finish that
    {
        return $"SimpleGoal:{_name},{_description},{_score}";
    }
    
}
