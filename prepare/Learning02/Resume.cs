
using System;

public class Resume
{
    // instances
    public string _fullName;
    public List<Job> _jobs = new List<Job>();


    // Methods
    public void displayJobInfo()
    {

        Console.WriteLine($"Name: {_fullName}\nJobs: "); 

        foreach(Job job in _jobs)
        {
            // Console.Write($"{job}");
            job.displayJobInfo();
        }
    }
}