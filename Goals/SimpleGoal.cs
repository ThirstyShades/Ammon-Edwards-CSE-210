public class SimpleGoal : Goal
{
    string test = "SimpleGoal";


public SimpleGoal() : base()
    {

    }

    public void TestPrint()
    {
        Console.WriteLine(test);
    }

public override int RecordEvent()
{
    Console.WriteLine("Simple Goal event recorded.");
    _isCompleted = true;
    return _score;

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