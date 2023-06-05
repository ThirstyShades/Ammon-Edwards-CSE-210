public class Elevator{
    protected bool doorState = true;
    protected int currentFloor = 1;

    public void doorClose(){
        doorState = false;
        Console.WriteLine("Door Closed");
    }
    public void doorOpen(){
        doorState = true;
        Console.WriteLine("Door Opened");
    }
    virtual public string listFloors(){
        return "Available Floors: B ---> 30";
    }
    virtual public string displayFloor(){
        return $"Current Floor: {currentFloor}";
    }
    
    virtual public void moveElevator(){
        Console.WriteLine("Which floor would you like to go to?");
        
        int moveFloor = Console.ReadLine();
        if (moveFloor > 30 && moveFloor < 0 ){
            Console.WriteLine("Floor Not Accessible");
        }else{
        if(doorState = true){
        currentFloor = moveFloor;
        }
        else{
            Console.WriteLine("Please close the door before selecting floor");
        }
        }
    }


}
