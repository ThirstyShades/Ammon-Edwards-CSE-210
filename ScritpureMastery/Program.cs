//Mosiah 20:11
Referance referance = new Referance("Mosiah", 20, 11);
referance.DisplayReferance();
Scripture scripture1 = new Scripture(referance);
scripture1.SplitText();
scripture1.DisplayScripture();


// while loop


// track index tell me what are the words hidden and the ones not hidden and pull from that list


string userChoice = ""; // while loop that ends when the user enters quit or the scripture is fully hidden IE it's index is equal to the used index
while(userChoice != "quit"){

// Menue display
Console.WriteLine($"\n---------------------------------------------------------------------------\nPress enter to hide a word, type show to reveal a word, type quit to exit the program"); 
userChoice = Console.ReadLine();

switch(userChoice)
{
    case "":
    scripture1.HideWord();
    scripture1.DisplayScripture();
    break;

    case "quit":
    break;

    case "Quit":
    break;

    case "hide":
    scripture1.HideWord();
    scripture1.DisplayScripture();
    break;

    case "show":
    scripture1.ShowWord();
    scripture1.DisplayScripture();
    break;

    case "Hide":
    scripture1.HideWord();
    scripture1.DisplayScripture();
    break;

    case "Show":
    scripture1.ShowWord();
    scripture1.DisplayScripture();
    break;

}

}



















