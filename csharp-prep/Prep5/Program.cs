using System;
 

/*
The general structure of a function definition in C# is:


returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function_body
}

To define a standalone function in C#, use the static keyword before the return type:


static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
Until we start writing classes, you should put the static keyword in front of all your functions.

*/


class Program
{
    static void Main(string[] args)
    {

    DisplayWelcome();

    string UserName = DisplayName(); 

    int number = FavNumber();

    int SquaredNumber = SquareNumber
    (number);

    DisplayNameAndNumber(UserName, SquaredNumber); // did not like float idk why messed everything up from before. 

    }


    static void DisplayWelcome()
{
    Console.WriteLine($"\nWelcome to the program!"); 
}

    static string DisplayName()
    {
        Console.WriteLine($"\nWhat is your name? "); 
        string name = Console.ReadLine();
        return name;
    }

    static int FavNumber()
    {
        Console.Write("What is your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

        // float square = Math.Sqrt(number);
        // return square; // I thought we needed to find the square root becease I am stuiped. 
    }

    static void DisplayNameAndNumber(string name, int square)
    {

    Console.WriteLine($"{name}, the square of your number is {square}");

    }

}