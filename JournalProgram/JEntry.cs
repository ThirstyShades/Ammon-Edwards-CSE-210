public class JEntry
{

    // Journal entry attributres. 
    private string _prompt; 
    private string _dateTime; 
    private string _response;

// Journal entry Constructor
public JEntry(string prompt, string responce)
{
    _prompt = prompt; 
    _response = responce; 
    DateTimeNow();
}

// get datetime for Jentrys
public void DateTimeNow()
{
    DateTime dt = DateTime.Now;
    string dateTimeNow = dt.ToString(); 
    _dateTime = dateTimeNow; 
}

//Display Entrys
public void DisplayEntrys() 
{
    Console.WriteLine($"The prompt was: {_prompt}\nEntry: {_response}\n{_dateTime}");
}

public string DisplaySavableEntrys()
{
   return $"The prompt was: {_prompt}\nEntry: {_response}\n{_dateTime}";
}
  

    


// public void GetEntry()
// {

// }



}