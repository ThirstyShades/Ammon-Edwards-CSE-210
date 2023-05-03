public class Car{

// instances (attributes)
public string brand; 
public int miles; 
public string color; 



// constructor (not allways manditory)
public Car(){ // this dose not do anything rn but the program will still run

}

// methonds (fuctions) things the car can do
public void MoveForward(){
    Console.Write("Is running."); 
}

public void PrintInstances(){

    Console.Write($"The brand is: {brand}.\nThe miles on the car are: {miles}\nThe color of the car is: {color}.");

}
}