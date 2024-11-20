using System;

namespace oopcsharp.Program4Methods;

class Program {
    public static void Main(string[] args){
        var LaptopMachine = new LaptopMachine();
        LaptopMachine.Execute("Vlc");

        Console.WriteLine(LaptopMachine.GetManufacturer());

        Console.WriteLine(LaptopMachine.Product(2.3, 5));

        Console.WriteLine(LaptopMachine.Product(5.1, 8));
    }
}