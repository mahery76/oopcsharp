using System;

namespace Program2AccessModifiers;

public class Program
{
    public static void Main(string[] args)
    {
        var LaptopMachine = new LaptopMachine();
        Console.WriteLine("the storage of the machine is: {0}", LaptopMachine._storage);
    }
}
