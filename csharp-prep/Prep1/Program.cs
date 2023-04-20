using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string F_name = Console.ReadLine(); 
        Console.Write("What is your last name? ");
        string L_name = Console.ReadLine();
        Console.Write($"\nYour name is {L_name}, {F_name} {L_name}.");
    }
}