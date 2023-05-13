// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Journal ammonsJournal = new Journal(); // make new journal



int userChoice = 0; // while loop that ends when the user enters 6 to quit
while(userChoice != 6){

// Menue display
Console.WriteLine("Please choose one of the fallowing");
Console.WriteLine("1. Write");
Console.WriteLine("2. Display");
Console.WriteLine("3. Load");
Console.WriteLine("4. Save");
Console.WriteLine("5. Add Prompt");
Console.WriteLine("6. Quit");
Console.Write("What would you like to do? ");
userChoice = int.Parse(Console.ReadLine());

// switch statment (If statment but wayyy better)
switch(userChoice)
{
    case 1: // add entrys
    
     // prompt
    Prompt prompt = new Prompt(); 
    string displayedPrompt = prompt.GetRandomPrompt();
    Console.WriteLine(displayedPrompt);
    // Responce
    Console.Write("> ");
    string userResponce = Console.ReadLine();
    //Add displayed prompt and the users responce to it
    JEntry entry = new JEntry(displayedPrompt, userResponce);
    ammonsJournal.AddEntry(entry);

    break;

    case 2: // Show entrys
    ammonsJournal.DisplayEntrys();
    
    break;

    case 3:// load
    Console.WriteLine("What is the file name: ");
    Console.Write("> ");
    string uiFileNameLoad = Console.ReadLine(); 
    ammonsJournal.LoadEntrys(uiFileNameLoad);
    break;

    case 4:// Save
    Console.WriteLine("What is the file name: ");
    Console.Write("> ");
    string uiFileNameSsave = Console.ReadLine(); 
    ammonsJournal.SaveEntrys(uiFileNameSsave);

    break;

    case 5: // Add new prompt to list (failed attempt to be creative lol)
    // Prompt prompt2 = new Prompt();
    // Console.WriteLine("Please enter a new prompt.");
    // Console.Write("> ");
    // string uiNewPrompt = Console.ReadLine(); 
    // prompt2.AddPrompt(uiNewPrompt);
    Console.WriteLine("This option is not currently working as the Prompt class consists of a list of strings. This is makign it difficult for me to implement this option, please try again later");

    break;

    case 6: // quit display
    Console.WriteLine("Thank you, goodybye.");

    break;

}
}
