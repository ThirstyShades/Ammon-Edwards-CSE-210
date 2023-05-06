// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Source tateSource = new Source("Breathe Air - Andrew Tate | Tate On Vapes", "https://www.youtube.com/watch?v=uMZZ8WgM82k");

// Console.WriteLine(tateSource.Stringify());

Quote andrewTate = new Quote("Andrew Tate", "Breath air! you don't need a vape.", tateSource);

// Console.WriteLine(andrewTate.GetQuote()); 

Board quoteboard = new Board();

quoteboard.AddQuote(andrewTate);
quoteboard.FindQuotesByAuthor("Andrew Tate");

Menu _menu = new Menu(quoteboard);
_menu.Display();