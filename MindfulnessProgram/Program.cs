using System;









int userChoice = 0; // while loop that ends when the user enters 4 to quit
while(userChoice != 4){

// Menue display
Console.Clear();
Console.WriteLine("\nPlease choose one of the fallowing");
Console.WriteLine("1. Start breathing activity");
Console.WriteLine("2. Start reflecting activity");
Console.WriteLine("3. Start listing activity");
Console.WriteLine("4. Quit");

userChoice = int.Parse(Console.ReadLine());


switch(userChoice)
{
    case 1: // Breathing
    // Activity test = new Activity();
    BreathingActivity breathing = new BreathingActivity(BreathingTime());
    Console.Clear();
    breathing.WellcomeMessage();
    Thread.Sleep(5000);
    Console.Write("Get ready...");
    breathing.Spinner();
    for(int i =0;i<3;i+=1)//i++
    {
        Thread.Sleep(450);
        breathing.BreathIn();
        breathing.CountDown();
        Thread.Sleep(450);
        breathing.BreathOut();
        breathing.CountDown();
    }
    breathing.EndMessage();
    Thread.Sleep(5000);
    
    break;

    case 2: 
    ReflectingActivity reflecting = new ReflectingActivity(ActivityTime());
    Console.Clear();
    reflecting.WellcomeMessage();
    reflecting.Instructions();
    reflecting.EndMessage();
    



    
    
    break;

    case 3:

    break;

    case 4:

    break;

}

    // I would have done this different now that I see more and know more however there is no time. 
    static int ActivityTime()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int activityTime = int.Parse(Console.ReadLine());
        return activityTime;
    }

        static int BreathingTime()
    {
        Console.WriteLine("How long, in second, would you like your breathing intervals [0s-10s]? ");
        int activityTime = int.Parse(Console.ReadLine());
        return activityTime;
    }
}

