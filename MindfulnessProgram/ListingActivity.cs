public class ListingActivity : Activity
{
    private string wellcomeMessage = $"Wellcome to the Listing Activity\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in the given time frame";


    public ListingActivity(int activityTime):base(activityTime)
    {
        
    }

    public void WellcomeMessage()
    {
        Console.WriteLine(wellcomeMessage);
    }

    public void Instructions()
    {
        Console.Clear();
        Console.WriteLine("List as many responces you can to the fallowing prompt:");

        Console.WriteLine("Prompt Placeholder");

        Timer(); //5s timer
    }


    public void UserInput()
    {
        // int listingTime = _activityTime;
        // int startTime = getdatetime now
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_activityTime);
        int inputCount = 0;
        
        while(DateTime.Now < futureTime)
        {
            Console.Write(">>>");
            Console.ReadLine();
            inputCount += 1;
        }
        Console.WriteLine($"You listed {inputCount} items!\nWell done!!");
        
    }

    public void EndMessage()
    {
        Console.WriteLine($"You have compleated another {_activityTime}s Listing Activity");
        Spinner();
    }



}