

class Vehicle //base class
{
    public string Brand = "Ford";
    public void Honk()
    {
        Console.WriteLine("Tuut, tuut");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string  ModelName = "Mustang"; 
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        myCar.honk();
        Console.WriteLine(myCar.ModelName + " " + myCar.Brand);
    }
}

//cannot be inherited
sealed class Device 
{
    public string Type = "Laptop";
}

//  'Computer': cannot derive from sealed type 'Device'
class Computer : Device
{
    ...
}

