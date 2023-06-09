public class Activity
{
    protected int _activityTime;
    private int _spinnerSpeed = 450;

    private int _timerTime = 5;



    public Activity(int activityTime)
    {
        _activityTime = activityTime;
    }

    // public void AskTime()
    // {
    //     Console.WriteLine("Who long, in second, would you like for your session?");
    //     _activityTime = int.Parse(Console.ReadLine());
    //     Console.WriteLine(_activityTime);
    // }

    public void Spinner()
    {
  
        Console.Write("|");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("/");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("|");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("/");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(_spinnerSpeed);// pass in ms
        Console.Write("\b");

        // Console.Write("|");
        // Thread.Sleep(_spinnerSpeed);// pass in ms
        // Console.Write("\b");
    }

    // public void SpinnerTime()
    // {
    // int deration = _activityTime;
    // while(deration >0)//i++
    // {
    //     Console.Write("|");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("/");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("-");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("\\");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("|");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("/");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("-");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
    //     Console.Write("\\");
    //     Thread.Sleep(_spinnerSpeed);// pass in ms
    //     Console.Write("\b");
        

    //     deration -= (_spinnerSpeed/1000)*8;

       
    // }

    

        

    //     // Console.Write("|");
    //     // Thread.Sleep(_spinnerSpeed);// pass in ms
    //     // Console.Write("\b");

    // }

    public void Timer()
    {
        Console.Write("\nYou may begine in: ");
        int value = _timerTime;
        while(value !=0)
        {
            Console.Write(value);
            Thread.Sleep(1000);
            if(value < 10)
            {
                Console.Write("\b");
                value -= 1;
            }
            else if(value >= 10 && value <100)
            {
                Console.Write("\b\b");
                value -= 1;

            }
            else
            {
                Console.WriteLine("Error int out of range");
                break;
            }
        }
        Console.WriteLine("");
    }


    public void CountDown() // for bearthing act
    {
        int value = _activityTime;
        while(value !=0)
        {
            Console.Write(value);
            Thread.Sleep(1000);
            if(value < 10)
            {
                Console.Write("\b");
                value -= 1;
            }
            else if(value >= 10 && value <11)
            {
                Console.Write("\b\b");
                value -= 1;

            }else
            {
                Console.WriteLine("\nError please try again; your out of the safe constraint [0s-10sec]\n*Becease I said so (OuO)");
                Thread.Sleep(5000);
                break;
            }

            
            
        }
        Console.WriteLine("");// New line
        
        
    }

    // public void CountDown()
    // {
    //     int value = _activityTime;
    //     while(value !=0)
    //     {
    //         Console.Write(value);
    //         Thread.Sleep(1000);
    //         if(_activityTime < 10 && _activityTime > 0 && _activityTime < 100)
    //         {
    //             Console.Write("\b");
    //             value -= 1;
    //         }
    //         else if(_activityTime > 10 && _activityTime > 0 && _activityTime < 100)
    //         {
    //             Console.Write("\b\b");
    //             value -= 1;
    //         }else
    //         {
    //             Console.WriteLine("Error please try again");
    //         }

            
            
    //     }
        
    // }


}
