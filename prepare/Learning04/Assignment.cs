public class Assignment
{
    string _studentName;
    string _topic;


    public Assignment(string studentName, string topic)
    {
        _topic = topic;
        _studentName = studentName;

    }
    public void GetSummary()
    {
        Console.WriteLine($"Student name: {_studentName}\nTopic: {_topic}");
    }
}