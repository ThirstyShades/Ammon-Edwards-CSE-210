using System;
using System.Collections.Generic; // Importent
class Program


/*

List<int> numbers = new List<int>();
List<string> words = new List<string>();

 numbers.Add(int) words.Add("string")

You can get the size of the list with the Count property.

Console.WriteLine(words.Count);


The easiest (and safest) way to iterate through a list in C# is to use the foreach loop:

foreach (string word in words)
{
    Console.WriteLine(word);

    You can also access the items by their index:

C#


for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}
Python


for i in range(len(words)):
    print(words[i])
}


*/


{
    static void Main(string[] args)
    {
        // Make list of numbers from user input
        int number = 1; 
        List<int> numbers = new List<int>();
            Console.Write("Enter as many numbers as you please; when you are finsihed enter a zero. I will then compute there sum, avrg, and highest int from the numbers entered.\n");
        do 
        {
            Console.Write("Enter a number: ");
            string userinput = Console.ReadLine();
            number = int.Parse(userinput);
            numbers.Add(number); 
        }while (number != 0);

        //for loop time
        int sum = 0;
        int biggest_num = -1000000;
        foreach (int index in numbers)
        {
            // compute the sum
            sum += index;  
            //Find biggest number
            if (index > biggest_num)
                biggest_num = index;    
        }

        Console.Write($"The sum is: {sum}");   
        //Compute the average
        int average = 0;
        average =  sum/(numbers.Count-1);
        Console.Write($"\nThe average is: {average}");
        Console.Write($"\nThe biggest number is {biggest_num}");  


    }
}