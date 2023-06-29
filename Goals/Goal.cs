public abstract class Goal  
{

    
    protected int _score;
    protected string _name;
    protected string _description;
    protected bool _isCompleted;



    public Goal() 
    {
        
        Console.WriteLine("Enter the number of points you will get by compleating this goal:");
        _score = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name of the goal:");
        _name = Console.ReadLine();

        Console.WriteLine("Enter the description:");
        _description = Console.ReadLine();
    }

    public abstract int RecordEvent(); // Records the goal has taken place and returns it's score

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[{(_isCompleted ? "X" : " ")}] {_name} | {_description} | {_score}");
    }

    public abstract string Serialize(); // Serialize the contencts to be loaded and unloaded from a txt file.
  



    public int GetScore()
    {
        return _score;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }

}
// is compleated method
// 








































// public abstract class Goal
// {
//     private int _score;
//     private string _name;
//     private string _discirption;

//     public Goal(int score, string name, string discirption) // I would like the user to be promted with text befor promting them with the input nessasry for this constructor somthing like this: // Console.Writeline("What is the name of your goal?"); name = Console.ReadLine();
//     {
        
//         _score = score;
//         _name = name;
//         _discirption = discirption;
//     }

//     public int GetScore()
//         {
//             return _score;
//         }

//     public string GetName()
//     {
//         return _name;
//     }

//     public string GetDiscirption()
//     {
//         return _discirption;
//     }



    

//     // public abstract double GetArea(); exsample of a abstrcat method.


// }