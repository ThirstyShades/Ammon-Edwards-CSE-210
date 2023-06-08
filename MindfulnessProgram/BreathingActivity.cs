public class BreathingActivity : Activity
{
    
    private string wellcomeMessage = "Wellcome to the breathing Activity.\nThis activity will help you relax by walking you though breathing in and out slowly. Clear your mind and focus on your breathing";

    public BreathingActivity(int activityTime):base(activityTime)
    {
        
    }

    public void BreathIn()
    {
        Console.WriteLine($"Breath in..."); // fuction to display time Console.WriteLine($"Breath in...{animation}");
        Console.Write(5);
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write(4);
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write(3);
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write(2);
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write(1);
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write(1);
        Thread.Sleep(1000);
        Console.Write("\b");
        Console.Write(0);
        Thread.Sleep(1000);
        Console.Write("\b");
 
        

    }


}