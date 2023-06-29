using System.IO; 

// I did not have time to finish this however I hope you can see I put coniderable effort into it's fuction and I hope at the least some partal credit can be awareded for my efforts. I will possibly get the chance in the furuter to finish it's functionality, however, I simply do not have thta kind of time or energy at the moment. I have lots to do.

public class SaveLoad //: System.IO.TextWriter
{

    // attributes
    string _filename;

    public void Save(List<Goal> goals)
    {
        Console.WriteLine("What is the file name?");

        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // write score
            foreach(Goal goal in goals)
                {
                    outputFile.WriteLine(goal.Serialize());
                }
                
        }  
        Console.WriteLine("Save Compleate!");
    }

    public void Load(string _filename)
    {
        // Console.WriteLine("What is the file name?");
        // _filename = Console.ReadLine();
        string[]/* list of strings*/ lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] goalSplit = line.Split(":");// make a array of Goal types splitting on :
            string goalType = goalSplit[0];// on the line above there are now lists of Goal types that are each one index long so we can now grab the goal type as a chuck. 
            string goalData = goalSplit[1];// with that chunk we now grab everything after it as one chuck of parts (name, desc, score, etc)
            string[] parts = goalData.Split(",");// Split that chuck of parts into idnivdual parts

            // the parts array now contains all the info we need
            if(goalType != "EternalGoal")
            {
                string _name = parts[0];
                string _description = parts[1];
                int _score = int.Parse(parts[2]);
            }      
            else
            {
                string _name = parts[0];
                string _description = parts[1];
                int _score = int.Parse(parts[2]);
                int _bonuseScore = int.Parse(parts[3]);
                int _actsRecorded = int.Parse(parts[4]);
                int _actsNeeded = int.Parse(parts[5]);
            } 

        }
            

    }
    
}


   // // You can add text to the file with the WriteLine method
        // outputFile.WriteLine("This will be the first line in the file.");
        
        // // You can use the $ and include variables just like with Console.WriteLine
        // string color = "Blue";
        // outputFile.WriteLine($"My favorite color is {color}");


