using System.IO;
public class Journal
{
    List<JEntry> entriesList = new List<JEntry>();
    // private string _author;
    // private string _quote;
    // private Source _source; not needed for core req but tryed to add

public void AddEntry(JEntry entry) // add entry to Jentry list method
{
    entriesList.Add(entry);
}


public void DisplayEntrys() // display entrys
{
    Console.WriteLine("---------------------------");
    foreach(JEntry entry in entriesList)
    {
        entry.DisplayEntrys();
        Console.WriteLine("---------------------------");
    }
}

public void SaveEntrys(string uiFileName) // save entrsy to a file that user passes it's name and type for.
{
    using (StreamWriter outputFile = new StreamWriter(uiFileName))
{
        foreach(JEntry entry in entriesList)
    {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(entry.DisplaySavableEntrys());
    }  
}
}
public void LoadEntrys(string uiFileName) // print the entrys from the file
{
    string[] lines = System.IO.File.ReadAllLines(uiFileName);

    foreach (string line in lines)
    {
        Console.WriteLine(line); 
    }   
}

}