// See https://aka.ms/new-console-template for more information

// DVD
Dvd theWayOfKing = new Dvd("The Way of Kings");
theWayOfKing.checkOut();
theWayOfKing.Display();

//Book
Book percyJackson = new Book($"Percy Jackson", "Author andwhatever", 1234);
percyJackson.checkOut();
percyJackson.Display();

//Protected is in both the parent and child
// to overdie a method the name must be the same nad have virutal in front of the prent ethod and overide i nthe child method
// Keep inharetance sallow and minimal.