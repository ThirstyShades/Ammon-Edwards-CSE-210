using System;









int userChoice = 0; // while loop that ends when the user enters 6 to quit
while(userChoice != 4){

// Menue display
Console.WriteLine("Please choose one of the fallowing");
Console.WriteLine("1. Start breathing activity");
Console.WriteLine("2. Start reflecting activity");
Console.WriteLine("3. Start listing activity");
Console.WriteLine("4. Quit");

userChoice = int.Parse(Console.ReadLine());

// switch statment (If statment but wayyy better)
switch(userChoice)
{
    case 1: // Breathing
    // Activity test = new Activity();
    BreathingActivity breathing = new BreathingActivity(BreathingTime());
    breathing.Spinner();
    breathing.BreathIn();


    break;

    case 2: 
    
    
    break;

    case 3:

    break;

    case 4:

    break;

}


    static int ActivityTime()
    {
        Console.WriteLine("How long, in second, would you like for your session?");
        int activityTime = int.Parse(Console.ReadLine());
        return activityTime;
    }

        static int BreathingTime()
    {
        Console.WriteLine("How long, in second, would you like your breathing intervals?");
        int activityTime = int.Parse(Console.ReadLine());
        return activityTime;
    }
}

