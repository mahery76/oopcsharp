using System;

namespace oopcsharp.Program4Methods;

class LaptopMachine
{
    public void Execute(string application)
    {
        Console.WriteLine("You just execute: " + application);
    }

    string manufacturer = "Dell";

    public String GetManufacturer()
    {
        return manufacturer;
    }

    // method overloading
    
    public double Product(double x, double y)
    {
        return x * y;
    }

    // Overloading the function to handle three arguments
    public double Product(double x, double y, double z)
    {
        return x * y * z;
    }
}
