using System;
namespace oopcsharp.Program3Fields;
public class Program
{
    public static void Main(string[] args)
    {
        var LaptopMachine = new LaptopMachine();
        LaptopMachine.Count = 25;
        Console.WriteLine(
            "{0}, {1}, {2}",
            LaptopMachine.Storage,
            LaptopMachine.Count,
            LaptopMachine.manufacturer
        );
    }
}


