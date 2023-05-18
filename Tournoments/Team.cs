public class Team
{
    // private by defalt
    // Player _player1;
    // Player _player2;

    List<Player> _playerList = new List<Player>();
    string _teamName;


// public Team(Player p1, Player p2);

public Team(string teamName)
{
    _teamName = teamName;
}

public void AddPlayer(Player p)
{
    _playerList.Add(p);
}

public void DisplayerRoster()
{
    Console.WriteLine($"{_teamName}:");
    foreach (Player player in _playerList)
    {
        player.DisplayPlayerDetails();
    }
}
}




// math class win and close and will add a win and a loss to a team