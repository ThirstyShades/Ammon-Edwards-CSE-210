public class Activity
{
    protected int _activityTime;



    public Activity(int activityTime)
    {
        _activityTime = activityTime;
    }

    // public void AskTime()
    // {
    //     Console.WriteLine("Who long, in second, would you like for your session?");
    //     _activityTime = int.Parse(Console.ReadLine());
    //     Console.WriteLine(_activityTime);
    // }

    public void Spinner()
    {
        Console.WriteLine("Get ready...");
        Console.Write("|");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("/");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("|");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("/");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(1000);// pass in ms
        Console.Write("\b");

    }

    // public void CountDown()
    // {
    //     foreach(i in BreathingTime())
    //     Console.Write(5);
    //     Thread.Sleep(1000);
    //     Console.Write("\b");
    // }


}
