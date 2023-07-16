
//Addresses   
Address address1 = new Address("843 woodcock road", "Dunlap", "TN", "USA");
Address address2 = new Address("123 some street", "some city", "some state", "some country");
Address address3 = new Address("456 the street", "the city", "the state", "the country");
// dates
DateTime date1 = new DateTime(2023, 7, 15);
DateTime date2 = new DateTime(2023, 8, 20);
DateTime date3 = new DateTime(2023, 9, 25);
// times
string time1 = ("12:00pm");
string time2 = ("1:00pm");
string time3 = ("2:00pm");

// make all the events
Lecture lecture = new Lecture("The best Lecture", "this is a lecture about lectures", date1, time1, address1, "your mom", 100);
Reception reception = new Reception("The best Reception", "this is a reception for receptions", date2, time2, address2, "rsvp@byui.edu");
OutdoorGathering outdoorGathering = new OutdoorGathering("Event", "this is a event", date3, time3, address3, "Sunny");
// display
Console.Clear(); // I cleared the console to make it easy to see everything.
Console.WriteLine($"------------------------------------------------------------Wellcome to the grand idk, here are all the event details!-------------------------------"); //this is to help find the start of the program as there is alot of text, and I mean alot. 
Console.WriteLine($"--- Lecture ---");
Console.WriteLine($"---------------");
Console.WriteLine($"Standard details:\n");
Console.WriteLine(lecture.GetStandardDetails());
Console.WriteLine($"---------------");
Console.WriteLine($"Full details:\n");
Console.WriteLine(lecture.GetFullDetails());
Console.WriteLine($"---------------");
Console.WriteLine($"Short Description:\n");
Console.WriteLine(lecture.GetShortDescription());
Console.WriteLine($"---------------");

Console.WriteLine($"--- Reception ---");
Console.WriteLine($"---------------");
Console.WriteLine($"Standard details:\n");
Console.WriteLine(reception.GetStandardDetails());
Console.WriteLine($"---------------");
Console.WriteLine($"Full details:\n");
Console.WriteLine(reception.GetFullDetails());
Console.WriteLine($"---------------");
Console.WriteLine($"Short Description:\n");
Console.WriteLine(reception.GetShortDescription());
Console.WriteLine($"---------------");

Console.WriteLine($"--- Outdoor Gathering ---");
Console.WriteLine($"---------------");
Console.WriteLine($"Standard details:\n");
Console.WriteLine(outdoorGathering.GetStandardDetails());
Console.WriteLine($"---------------");
Console.WriteLine($"Full details:\n");
Console.WriteLine(outdoorGathering.GetFullDetails());
Console.WriteLine($"---------------");
Console.WriteLine($"Short Description:\n");
Console.WriteLine(outdoorGathering.GetShortDescription());
Console.WriteLine($"---------------");
    

