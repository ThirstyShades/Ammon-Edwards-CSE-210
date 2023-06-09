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

        Console.WriteLine("prompt placeholder");//prompt fuction from list

        Console.WriteLine("\nWhen you have somthing in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

        Timer();// generic timer in activity class. its countdown value can be changed it attributes.
        // Not sure if these need to be in a list and pulled

    }

    public void ReflectPrompts()
    {
        Console.Clear();
        int reflectingTime = _activityTime;
        while(reflectingTime > 0)
        {
            
            Console.WriteLine("Reflection Prompt Placeholder");//Display Refelct prompt
            Thread.Sleep(5000); //display spinner for 5s
            reflectingTime = reflectingTime - 5;
            
        }
       
    }

        public void EndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done!\nYou have sucesfully compleated another {_activityTime}s reflecting citivty!");
        Thread.Sleep(5000);
    }
}