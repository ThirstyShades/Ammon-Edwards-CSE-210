using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 101);

        int guess_num = -1; 
        Console.Write($"\nTry and guess the magic number between 1 and 100"); 
        do
        {
            Console.Write($"\nWhat is your guess? "); 
            string input_2 = Console.
            ReadLine();
            guess_num = int.Parse(input_2);

            if(magic_num == guess_num)
            {
                Console.Write("You guessed it!");
            
            }
            else if (magic_num > guess_num)
            {
                Console.Write("Guess Higher");
                
            }
            else if (magic_num < guess_num)
            {
                Console.Write("Guess Lower");
                
            }
        } while (magic_num != guess_num);
    }
}
