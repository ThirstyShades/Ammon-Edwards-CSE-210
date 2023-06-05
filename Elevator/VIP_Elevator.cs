public class VIP_Elevator : Elevator
{
    int _accessCode;
    int _enteredCode;

  public VIP_Elevator(int accessCode)
  {
    _accessCode = accessCode;
  }

  public void SetInputCode()
  {
    Console.Write("What is the access code? ");
    string temp = Console.Readline();
    _enteredCode = int.Parse(temp);
  }

public bool CheckCode()
{
    if(_enteredCode == _accessCode)
    {
        return true;
    }else
    {
        return false;
    } 
    
}

override public string listFloors(){
    return "Available Floors: B ---> 31";
}

    override public void moveElevator(){
        Console.WriteLine("Which floor would you like to go to?");
        
        int moveFloor = Console.ReadLine();
        if (moveFloor > 31 && moveFloor < 0 ){
            Console.WriteLine("Floor Not Accessible");
        }else{
        if(doorState = true){
        currentFloor = moveFloor;
        }
        else{
            Conosole.WriteLine("Please close the door before selecting floor");
        }
        }
    }

}