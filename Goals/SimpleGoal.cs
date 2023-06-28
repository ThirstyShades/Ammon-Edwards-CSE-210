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
    
    

// }


    // what attributes are different or need to be added?

    // what dose the constructor look like? Do we need to make new attributes we did not inharit from the parent class?

    // what methods do we need?

    // how are we going to save and dispaly this information?
}

}























































// public class SimpleGoal : Goal
// {


// public SimpleGoal(int score, string name, string discirption) : base (score, name, discirption)
//     {
        
//     }













//     // what attributes are different or need to be added?

//     // what dose the constructor look like? Do we need to inharit attribuets from the parent class?

//     // what methods are we running?

//     // how are we going to save and dispaly this information?
// }