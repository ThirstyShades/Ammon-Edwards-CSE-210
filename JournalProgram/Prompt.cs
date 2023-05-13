public class Prompt
{
List<string> _prompsList = new List<string>();
// just make a new list for the new prompts and display them with a option!

public Prompt() // everytime a new prompt is made append these prompts to the list
{
    _prompsList.Add("What makes you happy?");
    _prompsList.Add("What is your primary goal in life?");
    _prompsList.Add("Ten years from now, where do you see yourself?");
    _prompsList.Add("What is your current assement of the world?");
    _prompsList.Add("If you chould change one thing about your life, what would it be?");
}

    public string GetRandomPrompt() //get random prompt to display to the user.
    {
        var random = new Random();
        var randomNumber = random.Next(0,_prompsList.Count);
        string randPrompt = _prompsList[randomNumber];
        
        return randPrompt;
    }

    // public void AddPrompt(string uiNewPrompt)
    // {
    //     _prompsList.Add(uiNewPrompt);
    // }

    // public void DisplayPrompt()
    // {
    //     Console.WriteLine($"");
    // }

//   public void DisplayPrompts()
// {
//     Console.WriteLine("---------------------------");
//     foreach(Prompt prompt in _prompsList)
//     {
//         prompt.DisplayPrompt();
//         Console.WriteLine("---------------------------");
//     }
}


