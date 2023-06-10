public class ReflectingActivity : Activity
{
    private string wellcomeMessage = $"Wellcome to the Reflecting Activity\nThis activity will help you reflect on times in yur life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";

    List<string> _prompsList = new List<string>();
    List<string> _reflectoinsList = new List<string>();

    public ReflectingActivity(int activityTime):base(activityTime)
    {
        // prompts to reflect upon
        _prompsList.Add("Think of a time when you stood up for someone else.?");
        _prompsList.Add("Think of a time when you did something really difficult.");
        _prompsList.Add("Think of a time when you helped someone in need.");
        _prompsList.Add("Think of a time when you felt like you couldn't acompish your goals.");
        _prompsList.Add("Think of a time when you did something truly selfless.");
        //Reflectoin prompts
        _reflectoinsList.Add("Why was this experience meaningful to you?");
        _reflectoinsList.Add("Have you ever done anything like this before?");
        _reflectoinsList.Add("How did you get started?");
        _reflectoinsList.Add("How did you feel when it was complete?");
        _reflectoinsList.Add("What made this time different than other times when you were not as successful?");
        
    }

    public void WellcomeMessage()
    {
        Console.WriteLine(wellcomeMessage);
    }

    public void Instructions()
    {
        Console.WriteLine("Consider the fallowing prompt\n");

        Console.WriteLine(GetRandomPrompt());//prompt fuction from list

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
            
            Console.WriteLine(GetRandomReflectoin());//Display Refelct prompt
            SpinnerTime5s(); //display spinner for 5s loop for deration
            reflectingTime = reflectingTime - 5;
            

        }
       
    }

        public void EndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done!\nYou have sucesfully compleated another {_activityTime}s reflecting citivty!");
        Spinner();
    }



     public string GetRandomPrompt() //get random prompt to display to the user.
    {
        var random = new Random();
        var randomNumber = random.Next(0,_prompsList.Count);
        string randPrompt = _prompsList[randomNumber];
        
        return randPrompt;
    }


     public string GetRandomReflectoin() //get random prompt to display to the user.
    {
        var random = new Random();
        var randomNumber = random.Next(0,_reflectoinsList.Count);
        string randPrompt = _reflectoinsList[randomNumber];
        
        return randPrompt;
    }
}