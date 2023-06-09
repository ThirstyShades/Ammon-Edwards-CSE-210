public class ReflectingActivity : Activity
{
    private string wellcomeMessage = $"Wellcome to the Reflecting Activity\nThis activity will help you reflect on times in yur life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";

    public ReflectingActivity(int activityTime):base(activityTime)
    {
        
    }

    public void WellcomeMessage()
    {
        Console.WriteLine(wellcomeMessage);
    }

    public void Instructions()
    {
        Console.WriteLine("Consider the fallowing prompt\n");

        Console.WriteLine("prompt");//prompt fuction from list

        Console.WriteLine("\nWhen you have somthing in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        Timer();// generic timer in activity class. its countdown value can be changed it attributes.
        // Not sure if these need to be in a list and pulled
        Console.Clear();
        Console.Write("How did you fell when it was complete? ");
        Spinner();
        Thread.Sleep(_activityTime/2);

        Console.Write("\nWhat is your favorite thing abot this experience?");
        Spinner();
        Thread.Sleep(_activityTime/2);

    }

        public void EndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done!\nYou have sucesfully compleated another {_activityTime}s reflecting citivty!");
        Thread.Sleep(5000);
    }
}