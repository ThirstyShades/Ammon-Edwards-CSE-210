
List<Goal> _goals = new List<Goal>(); // list of made goals I don't know a better place to put this atm
int overallScore = 0;

int userChoice = 0; 
while(userChoice != 6){

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
            
            Console.WriteLine("New Simple Goal");
            Goal simple1 = new SimpleGoal();
            _goals.Add(simple1);
            
            break;
        }
        else if(goalChoice == 2)
        {
            //New eternal goal
            Console.WriteLine("New Eternal Goal");
            break;

        }
        else if(goalChoice == 3)
        {
            //New Checklist goal
            Console.WriteLine("New Checklist Goal");
            break;
        }
        else
        {
            Console.WriteLine("Error Choice out of range");
            break;
        }

    

    case 2: 
    foreach (Goal i in _goals)
        {
            i.DisplayGoal();
        }

    break;

    case 3:
    break;

    case 4:
    break;

    case 5: // list goals, unser input to record a goal, take index of that input and add the score to the overallScore variable at the top of the program. If it is a simple goal, remove it or makr it compleat, eternal goals are never compleate, increment the list goal. 

    break;

    case 6: // quit display
    Console.WriteLine("Thank you, goodybye.");
    break;

}
}
