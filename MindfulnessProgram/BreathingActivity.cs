public class BreathingActivity : Activity
{
    
    private string wellcomeMessage = "Wellcome to the breathing Activity.\nThis activity will help you relax by walking you though breathing in and out slowly.\nClear your mind and focus on your breathing.";

    // private string endMessage = ($"Well done!\nYou have sucesfully compleated another {_activityTime} interval breathing acitivty!");
    
    public BreathingActivity(int activityTime):base(activityTime)
    {
        
    }

    

    public void WellcomeMessage()
    {
        Console.WriteLine(wellcomeMessage);
    }
    public void EndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done!\nYou have sucesfully compleated another {_activityTime}s interval breathing acitivty!");
    }
    

    public void BreathIn()
    {
        Console.Clear();
        Console.Write($"Breath in..."); // fuction to display time Console.WriteLine($"Breath in...{animation}");

    }

    public void BreathOut()
    {
        Console.Clear();
        Console.Write($"Breath Out..."); // fuction to display time Console.WriteLine($"Breath in...{animation}");

    }

   

}