// See https://aka.ms/new-console-template for more information
// // new folder, cd to new folder, dotnet new console 
// dotnet run to run program

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Car bugattiChiron = new Car(); // do not cap first char of a veribal

        bugattiChiron.brand = "Bugatti";
        
        bugattiChiron.color = "Purple";
        
        bugattiChiron.miles = 0;

        bugattiChiron.PrintInstances();
        bugattiChiron.MoveForward(); 

    }
}

