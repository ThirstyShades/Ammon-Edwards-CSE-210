public class Job{

    // instances 
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Methods
    public void displayJobInfo(){
    Console.Write($"Job Title: {_jobTitle}\nCompany: {_company}\nStart Year: {_startYear}\nEnd Year: {_endYear}\n"); 
    
}

}