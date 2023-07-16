
List<Activity> activities = new List<Activity> // instead of defining each class then appending them like I have in the past becease of the need for a interface I simply hard coded them into a list instead. 
{
    new Running("01 Jan 2023", 30, 3), // this is the same values as the instructions to make sure I got ti right idspite the fact somone running 3mph is a joke I am confident I can walk that fast. 
    new Cycling("02 Feb 2023", 45, 20),
    new Swimming("03 March 2023", 10, 12) 
};

// Instead of foreach (Activity activity in activities) you can just say var (short for varibual I think) and it dose not matter object is there! I understand we were thought to define it to better understand how to delcare stuff but this is so much simplar to code. 
foreach (var activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}
    


