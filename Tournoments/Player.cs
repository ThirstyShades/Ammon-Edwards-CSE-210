public class Player
{

  private string _name = "";
  private string _position = "N/A";
  private int _number;

public Player(string name, int number)
{
    _name = name;
    _number = number;
}
  
// This can be in the code to make a player with a position instead havign to call the fuctio nand can be impmemnted alongside the code above and the programe will be able to figure itself out. 

// public Player(string name, int number, string position)
// {
//     _name = name;
//     _number = number;
//     _position = position; 
// // }


public void SetPosition(string position)
{

    _position = position; 

}

public void DisplayPlayerDetails()
{
    Console.WriteLine($"Player name: {_name}\nPlayer Number: {_number}\nPlayer Position: {_position}");
}
}

