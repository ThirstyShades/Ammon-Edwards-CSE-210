
List<Goal> _goals = new List<Goal>(); // list of made goals I don't know a better place to put this atm
int overallScore = 0;


int userChoice = 0; 
while(userChoice != 6){

// Show points
Console.WriteLine($"Score: {overallScore}");
// Menue display
Console.WriteLine("Menu Options:");
Console.WriteLine("1. Create New Goal");
Console.WriteLine("2. List Goals");
Console.WriteLine("3. Save Goals");
Console.WriteLine("4. Load Goals");
Console.WriteLine("5. Record Event");
Console.WriteLine("6. Quit");
Console.Write("What would you like to do? ");
userChoice = int.Parse(Console.ReadLine());


switch(userChoice)
{
    case 1: 
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("What type of Goal would you like to create? ");
    
    int goalChoice = int.Parse(Console.ReadLine());

        if(goalChoice == 1)
        {
            
            Console.WriteLine("New Simple Goal:");
            Goal simple1 = new SimpleGoal(); // base goal has prompts and input logic
            _goals.Add(simple1);// add it to the list at the top of program
            
            break;
        }
        else if(goalChoice == 2)
        {
            Console.WriteLine("New Eternal Goal:");
            Goal eternal1 = new EternalGoal(); // base goal has prompts and input logic from user
            _goals.Add(eternal1);
            break;

        }
        else if(goalChoice == 3)
        {
            //New Checklist goal
            Console.WriteLine("New Checklist Goal");
            Goal checklist1 = new ChecklistGoal(); // base goal has prompts and input logic from user and in this case additional prompts and attributes in the Checklist goal class
            _goals.Add(checklist1);
            break;
        }
        else
        {
            Console.WriteLine("Error Choice out of range");
            break;
        }

    

    case 2: 
    int index = 1;
    foreach (Goal i in _goals)
        {
            Console.Write($"{index}: ");
            i.DisplayGoal();
            index += 1;
        }

    break;

    case 3:
    break;

    case 4:
    break;

    case 5: // list goals, unser input to record a goal, take index of that input and add the score to the overallScore variable at the top of the program. If it is a simple goal, remove it or makr it compleat, eternal goals are never compleate, increment the list goal. 
    int index2 = 1;
    foreach (Goal i in _goals)
        {
            Console.Write($"{index2}: ");
            i.DisplayGoal();
            index2 += 1;
        }
        Console.WriteLine("What goal did you compleate?");
        int selection = int.Parse(Console.ReadLine());
        overallScore += _goals[selection -1].RecordEvent();

    break;

    case 6: // quit display
    Console.WriteLine("Thank you, goodybye.");
    break;


}
}
