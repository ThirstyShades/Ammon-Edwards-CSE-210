public class ListingActivity : Activity
{
    private string wellcomeMessage = $"Wellcome to the Listing Activity\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in the given time frame";

    List<string> _prompsList = new List<string>();


    public ListingActivity(int activityTime):base(activityTime)
    {
    _prompsList.Add("What makes you happy?");
    _prompsList.Add("What is your primary goals in life?");
    _prompsList.Add("Ten years from now, where do you see yourself doing?");
    _prompsList.Add("If you chould change anything you wan'ted about your life, what would you change?");
        
    }

    public void WellcomeMessage()
    {
        Console.WriteLine(wellcomeMessage);
    }

    public void Instructions()
    {
        Console.Clear();
        Console.WriteLine("List as many responces you can to the fallowing prompt:");

        Console.WriteLine(GetRandomPrompt());

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

    public string GetRandomPrompt() //get random prompt to display to the user.
    {
        var random = new Random();
        var randomNumber = random.Next(0,_prompsList.Count);
        string randPrompt = _prompsList[randomNumber];
        
        return randPrompt;
    }



}