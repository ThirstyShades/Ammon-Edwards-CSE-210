public class Prompt
{
    List<string> _prompts = new List<string>();
    List<string> _usedPrompts;

    public Prompt()
    {
        _prompts.Add("How was your day? ");
    }


    //Methods
    public string getRandPrompt()
    {
        
        return "This is a prompt"; 
    }
}