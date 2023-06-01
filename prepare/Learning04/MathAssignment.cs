public class MathAssignment : Assignment
{
    string _textBookSection;

    string _problems;

    public  MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _problems = problems;
        _textBookSection = section;

    }
    public void GetHomeworkList()
    {
        Console.WriteLine($"{_textBookSection} {_problems}");
    }

    

}