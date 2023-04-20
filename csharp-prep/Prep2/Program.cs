using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string userinput = Console.ReadLine();
        int percent = int.Parse(userinput);

        string grade = ""; 

        if (percent >= 90)
        {
           grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
           grade = "F";  
        }

        Console.WriteLine($"Your letter grade is {grade}."); 
        

        if (percent >= 70)
        {
            Console.WriteLine("Good job you passed!");
        }
        else
        {
            Console.WriteLine("You failed.....");
        }
    }
}




















//  int x = 5;
//         int y = 2; 
//         if (x > y)
//         {
//             Console.WriteLine("Greater");
//         }
//         else if (x < y)
//         {
//             Console.WriteLine("less");
//         }
//         else
//         {
//             Console.WriteLine("Equal");
//         }
